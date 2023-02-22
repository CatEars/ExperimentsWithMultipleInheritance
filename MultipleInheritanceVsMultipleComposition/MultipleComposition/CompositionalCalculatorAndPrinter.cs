namespace MultipleInheritanceVsMultipleComposition.MultipleComposition;

public class CompositionalCalculatorAndPrinter : ICostCalculator, ICostPrinter
{
    private readonly CostCalculator _costCalculator = new();
    private readonly ReportPrinter _reportPrinter = new();
    
    public CostReport CalculateCost(VirtualServer server)
    {
        return _costCalculator.CalculateCost(server);
    }

    public IEnumerable<string> Print(CostReport report)
    {
        return _reportPrinter.Print(report);
    }
}