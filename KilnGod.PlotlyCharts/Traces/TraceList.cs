//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TraceList.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class TraceList
    {
        private List<Trace> _traces = new List<Trace>();

        private List<object> _traceValues = new List<object>();
        public TraceList(Trace? trace = null) : base()
        {
            if (trace != null)
            {
                AddTrace(trace);                
            }
        }

        public TraceList(Trace[] traces)
        {
            _traces.AddRange(traces);
            foreach(Trace trace in _traces)
            {
                _traceValues.Add(trace.ValueItems);
            }
        }

        public int AddTrace(Trace trace, int index = -1)
        {

            if (index == -1)
            {
                _traces.Add(trace);
                _traceValues.Add(trace.ValueItems);

            }
            else
            {
                _traces.Insert(index, trace);
                _traceValues.Insert(index, trace.ValueItems);
            }

            return _traces.IndexOf(trace);
        }

        public object Values 
        { 
            get{ return _traceValues; }
        }
      
    }
}
