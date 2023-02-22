namespace MultipleInheritanceVsMultipleComposition;

public interface ICostPrinter
{
    IEnumerable<string> Print(CostReport report);
}