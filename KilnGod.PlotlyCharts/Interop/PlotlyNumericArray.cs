//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyNumericArray.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace KilnGod.PlotlyCharts.Interop;

public enum PlotlyNumericArrayType : byte
{
    Int32,
    Float32,
    Float64
}

/// <summary>
/// Little-endian numeric bytes for the byte-oriented Plotly adapter path. The byte
/// buffer is owned by this value and must not be mutated until the awaited interop call
/// completes. It can then be reused by the caller for a later sequential update.
/// </summary>
public sealed class PlotlyNumericArray
{
    private PlotlyNumericArrayPayload? _payload;

    private PlotlyNumericArray(byte[] bytes, int elementCount, PlotlyNumericArrayType type)
    {
        Bytes = bytes;
        ElementCount = elementCount;
        ElementType = type;
    }

    public byte[] Bytes { get; }

    public int ElementCount { get; }

    public PlotlyNumericArrayType ElementType { get; }

    public static PlotlyNumericArray FromInt32(ReadOnlySpan<int> values)
    {
        var bytes = new byte[checked(values.Length * sizeof(int))];
        if (BitConverter.IsLittleEndian)
        {
            MemoryMarshal.AsBytes(values).CopyTo(bytes);
        }
        else
        {
            for (var index = 0; index < values.Length; index++)
            {
                BinaryPrimitives.WriteInt32LittleEndian(
                    bytes.AsSpan(index * sizeof(int), sizeof(int)), values[index]);
            }
        }

        return new(bytes, values.Length, PlotlyNumericArrayType.Int32);
    }

    public static PlotlyNumericArray FromSingle(ReadOnlySpan<float> values)
    {
        var bytes = new byte[checked(values.Length * sizeof(float))];
        if (BitConverter.IsLittleEndian)
        {
            MemoryMarshal.AsBytes(values).CopyTo(bytes);
        }
        else
        {
            for (var index = 0; index < values.Length; index++)
            {
                BinaryPrimitives.WriteInt32LittleEndian(
                    bytes.AsSpan(index * sizeof(float), sizeof(float)),
                    BitConverter.SingleToInt32Bits(values[index]));
            }
        }

        return new(bytes, values.Length, PlotlyNumericArrayType.Float32);
    }

    public static PlotlyNumericArray FromDouble(ReadOnlySpan<double> values)
    {
        var bytes = new byte[checked(values.Length * sizeof(double))];
        if (BitConverter.IsLittleEndian)
        {
            MemoryMarshal.AsBytes(values).CopyTo(bytes);
        }
        else
        {
            for (var index = 0; index < values.Length; index++)
            {
                BinaryPrimitives.WriteInt64LittleEndian(
                    bytes.AsSpan(index * sizeof(double), sizeof(double)),
                    BitConverter.DoubleToInt64Bits(values[index]));
            }
        }

        return new(bytes, values.Length, PlotlyNumericArrayType.Float64);
    }

    internal PlotlyNumericArrayPayload ToPayload()
    {
        var payload = Volatile.Read(ref _payload);
        if (payload is not null)
        {
            return payload;
        }

        var created = new PlotlyNumericArrayPayload(Bytes, ElementCount, ElementType.ToString());
        return Interlocked.CompareExchange(ref _payload, created, null) ?? created;
    }
}

/// <summary>
/// Serializable descriptor used by the batched numeric interop path. The byte buffer
/// is not copied; ownership remains with the originating <see cref="PlotlyNumericArray"/>
/// until the awaited interop call completes.
/// </summary>
public sealed class PlotlyNumericArrayPayload
{
    internal PlotlyNumericArrayPayload(byte[] bytes, int elementCount, string elementType)
    {
        Bytes = bytes;
        ElementCount = elementCount;
        ElementType = elementType;
    }

    public byte[] Bytes { get; }

    public int ElementCount { get; }

    public string ElementType { get; }
}
