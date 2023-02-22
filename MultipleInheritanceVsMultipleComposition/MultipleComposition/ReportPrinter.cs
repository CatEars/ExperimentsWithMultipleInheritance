namespace MultipleInheritanceVsMultipleComposition.MultipleComposition;

internal class ReportPrinter : ICostPrinter
{
    public IEnumerable<string> Print(CostReport report)
    {
        return new List<string>()
        {
            $"Bandwidth: {report.BandwidthCost}",
            $"Server: {report.ServerCost}"
        };
    }
}