//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: EnumerationStatic.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;
using System.Reflection;

namespace KilnGod.PlotlyCharts.Wrappers
{
    public static class EnumerationStatic
    {
        public static string GetDescription<T>(this T e) where T : Enum
        {
            var enumOption = typeof(T).GetTypeInfo().GetMember(e.ToString());
            var attribute = enumOption.FirstOrDefault(member => member.MemberType == MemberTypes.Field)?.GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute;
            return (attribute?.Description ?? e.ToString()).ToLower();
        }


        public static T? GetValueFromDescription<T>(string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                    {
                        return (T?)field.GetValue(null);
                        //return (T?) field.GetRawConstantValue();
                    }
                }
                else
                {
                    if (field.Name == description)
                    {
                        return (T?)field.GetValue(null);
                    }

                }
            }
            return default;
            //throw new ArgumentException("Not found.", nameof(description));
            // Or return default(T);
        }


        public static string MakeFlagList<T>(T[] enums) where T : Enum
        {
            string result = string.Empty;

            for (int i = 0; i < enums.Length; i++)
            {
                if (result == string.Empty)
                {
                    result = enums[i].GetDescription();
                } 
                else
                {
                    result = result + "+"+ enums[i].GetDescription();
                }
             
            }

            return result;
        }
    }
}
