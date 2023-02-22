namespace MultipleInheritanceVsMultipleComposition.MixinsAndMultipleInheritance;

internal interface ReportPrinterMixin : ICostPrinter
{
    IEnumerable<string> ICostPrinter.Print(CostReport report)
    {
        return new List<string>()
        {
            $"Bandwidth: {report.BandwidthCost}",
            $"Server: {report.ServerCost}"
        };
    }
}