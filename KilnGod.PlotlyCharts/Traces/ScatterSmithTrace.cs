using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ScatterSmithTrace : Trace
    {
        public ScatterSmithTrace() : base(TraceTypeOptions.Specialized_ScatterSmith)
        {
        }

        public object? Real
        {
            get { return (ValueItems as dynamic).real; }
            set { (ValueItems as dynamic).real = value; }
        }

        public object? Imaginary
        {
            get { return (ValueItems as dynamic).imag; }
            set { (ValueItems as dynamic).imag = value; }
        }
    }
}
