//***********************************************************************************
// KilnGod.PlotlyCharts
//
// File: PlotlyNumericBinaryPacket.cs
//***********************************************************************************

using System.Buffers.Binary;
using System.Text;

namespace KilnGod.PlotlyCharts.Interop;

/// <summary>
/// One named numeric field in the opt-in binary stream protocol.
/// Rows and columns are zero for one-dimensional fields.
/// </summary>
public sealed record PlotlyNumericBinaryField(
    string Name,
    PlotlyNumericArray Values,
    int Rows = 0,
    int Columns = 0);

/// <summary>
/// Builds the wire packet used by <see cref="PlotlyChart.RestyleNumericStream"/>.
/// The returned buffer is one contiguous allocation; callers should not mutate it
/// until the awaited interop operation has completed.
/// </summary>
public static class PlotlyNumericBinaryPacket
{
    private const uint Magic = 0x504E474B; // ASCII "KGNP" in little-endian order.
    private const byte Version = 1;

    public static byte[] Create(IReadOnlyList<PlotlyNumericBinaryField> fields)
    {
        var length = GetByteCount(fields);
        var buffer = new byte[length];
        Write(fields, buffer);
        return buffer;
    }

    /// <summary>Returns the exact packet size after validating the field metadata.</summary>
    public static int GetByteCount(IReadOnlyList<PlotlyNumericBinaryField> fields)
    {
        ValidateFields(fields);
        var length = 4 + 1 + 2;
        for (var index = 0; index < fields.Count; index++)
        {
            var field = fields[index];
            var nameLength = Encoding.UTF8.GetByteCount(field.Name);
            if (nameLength > ushort.MaxValue)
            {
                throw new ArgumentException($"Field name '{field.Name}' is too long.", nameof(fields));
            }

            length = checked(length + 2 + nameLength + 1 + 4 + 4 + 4 + 4 + field.Values.Bytes.Length);
        }

        return length;
    }

    /// <summary>
    /// Writes one packet into caller-owned storage. The destination must be at least
    /// <see cref="GetByteCount"/> bytes long and is never retained by this class.
    /// </summary>
    public static void Write(IReadOnlyList<PlotlyNumericBinaryField> fields, Span<byte> destination)
    {
        var length = GetByteCount(fields);
        if (destination.Length < length)
        {
            throw new ArgumentException("The destination is smaller than the packet.", nameof(destination));
        }

        var offset = 0;
        BinaryPrimitives.WriteUInt32LittleEndian(destination.Slice(offset, 4), Magic);
        offset += 4;
        destination[offset++] = Version;
        BinaryPrimitives.WriteUInt16LittleEndian(destination.Slice(offset, 2), (ushort)fields.Count);
        offset += 2;

        for (var index = 0; index < fields.Count; index++)
        {
            var field = fields[index];
            var nameLength = Encoding.UTF8.GetByteCount(field.Name);
            BinaryPrimitives.WriteUInt16LittleEndian(destination.Slice(offset, 2), (ushort)nameLength);
            offset += 2;
            offset += Encoding.UTF8.GetBytes(field.Name, destination.Slice(offset));
            destination[offset++] = (byte)field.Values.ElementType;
            BinaryPrimitives.WriteInt32LittleEndian(destination.Slice(offset, 4), field.Values.ElementCount);
            offset += 4;
            BinaryPrimitives.WriteInt32LittleEndian(destination.Slice(offset, 4), field.Rows);
            offset += 4;
            BinaryPrimitives.WriteInt32LittleEndian(destination.Slice(offset, 4), field.Columns);
            offset += 4;
            BinaryPrimitives.WriteInt32LittleEndian(destination.Slice(offset, 4), field.Values.Bytes.Length);
            offset += 4;
            field.Values.Bytes.AsSpan().CopyTo(destination.Slice(offset));
            offset += field.Values.Bytes.Length;
        }
    }

    private static void ValidateFields(IReadOnlyList<PlotlyNumericBinaryField> fields)
    {
        ArgumentNullException.ThrowIfNull(fields);
        if (fields.Count == 0 || fields.Count > ushort.MaxValue)
        {
            throw new ArgumentException("At least one and at most 65,535 fields are required.", nameof(fields));
        }

        for (var index = 0; index < fields.Count; index++)
        {
            var field = fields[index] ?? throw new ArgumentException("A field cannot be null.", nameof(fields));
            ArgumentException.ThrowIfNullOrEmpty(field.Name);
            ArgumentNullException.ThrowIfNull(field.Values);
            if (field.Rows < 0 || field.Columns < 0 ||
                ((field.Rows == 0) != (field.Columns == 0)) ||
                (field.Rows > 0 && checked(field.Rows * field.Columns) != field.Values.ElementCount))
            {
                throw new ArgumentException($"Invalid matrix dimensions for '{field.Name}'.", nameof(fields));
            }
        }
    }
}
