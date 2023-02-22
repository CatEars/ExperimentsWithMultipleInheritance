namespace MultipleInheritanceVsMultipleComposition.SingleInheritance;

public class BasicInheritanceCostCalculatorAndPrinter : ICostCalculator, ICostPrinter
{
    public CostReport CalculateCost(VirtualServer server)
    {
        var bandwidthCost = server.BandwidthUsage / 10;
        var serverMultiplier = server.Size == ComputeSize.Large ? 3 : server.Size == ComputeSize.Medium ? 2 : 1;
        return new CostReport(bandwidthCost, serverMultiplier * server.DaysActiveInMonth);
    }

    public IEnumerable<string> Print(CostReport report)
    {
        return new List<string>()
        {
            $"Bandwidth: {report.BandwidthCost}",
            $"Server: {report.ServerCost}"
        };
    }
}