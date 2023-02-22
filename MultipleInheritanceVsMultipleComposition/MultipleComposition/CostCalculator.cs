namespace MultipleInheritanceVsMultipleComposition.MultipleComposition;

internal class CostCalculator : ICostCalculator
{
    public CostReport CalculateCost(VirtualServer server)
    {
        var bandwidthCost = server.BandwidthUsage / 10;
        var serverMultiplier = server.Size == ComputeSize.Large ? 3 : server.Size == ComputeSize.Medium ? 2 : 1;
        return new CostReport(bandwidthCost, serverMultiplier * server.DaysActiveInMonth);
    }
}