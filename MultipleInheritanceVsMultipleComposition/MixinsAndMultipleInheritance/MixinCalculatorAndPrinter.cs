
namespace MultipleInheritanceVsMultipleComposition.MixinsAndMultipleInheritance;

public class MixinCalculatorAndPrinter : CostCalculatorMixin, ReportPrinterMixin, CostCalcAndPrint
{
    public ICostCalculator Calculator => this;
    public ICostPrinter Printer => this;

    public CostCalcAndPrint CostCalcAndPrint => this;
}