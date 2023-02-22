namespace MultipleInheritanceVsMultipleComposition.MixinsAndMultipleInheritance;

public interface CostCalcAndPrint
{
    protected ICostCalculator Calculator { get; }
    
    protected ICostPrinter Printer { get; }

    IEnumerable<string> PrintAndCalculate(VirtualServer server)
    {
        var result = Calculator.CalculateCost(server);
        return Printer.Print(result);
    }
}