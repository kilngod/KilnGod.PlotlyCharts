//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ItemList.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;
using System.Collections;

namespace KilnGod.PlotlyCharts.Wrappers
{

    /// <summary>
    /// List for Plotly's "templatedArray" of attributes
    /// 
    /// Note setting the hosting property of the templatedArray must be set as one shot, arrays may not be modified only 
    /// set in a single property set. Behind the scenes Plotly is calling a function on the incoming array therefor 
    /// piecemeal updates are not allowed. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ItemList<T> : IList<T> where T : ValuesObject
    {
        private List<T> _Items;

        public ItemList()
        {
            _Items = new List<T>();
        }

        public ItemList(T item)
        {
            _Items = new List<T>();
            _Items.Add(item);
        }

        public ItemList(T[] items)
        {
            _Items = new List<T>();
            foreach (T item in items) { _Items.Add(item); }            
        }


        public T this[int index] { get => ((IList<T>)_Items)[index]; set => ((IList<T>)_Items)[index] = value; }

        public object Values
        {
            get
            {
                List<object> values = new List<object>();
                foreach (var item in _Items)
                {
                    values.Add(item.ValueItems);
                }
                return values.ToArray();
            }
        }

        public int Count => ((ICollection<T>)_Items).Count;

        public bool IsReadOnly => ((ICollection<T>)_Items).IsReadOnly;

        public void Add(T item)
        {
            ((ICollection<T>)_Items).Add(item);
        }

        public void Clear()
        {
            ((ICollection<T>)_Items).Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)_Items).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)_Items).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_Items).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return ((IList<T>)_Items).IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            ((IList<T>)_Items).Insert(index, item);
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)_Items).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<T>)_Items).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_Items).GetEnumerator();
        }
    }
}
