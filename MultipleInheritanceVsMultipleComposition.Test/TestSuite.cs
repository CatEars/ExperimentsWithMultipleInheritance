using System.Collections.Generic;
using System.Linq;
using MultipleInheritanceVsMultipleComposition.MixinsAndMultipleInheritance;
using MultipleInheritanceVsMultipleComposition.MultipleComposition;
using MultipleInheritanceVsMultipleComposition.SingleInheritance;
using Xunit;

namespace MultipleInheritanceVsMultipleComposition.Test;

public class TestSuite
{

    public static IEnumerable<object[]> TestObjects => new List<object[]>()
    {
        new object[]{ new BasicInheritanceCostCalculatorAndPrinter() },
        new object[]{ new CompositionalCalculatorAndPrinter() },
        new object[]{ new MixinCalculatorAndPrinter() },
    };

    [Theory]
    [MemberData(nameof(TestObjects))]
    public void CostTest(ICostCalculator calculator)
    {
        var server = new VirtualServer(ComputeSize.Small, 100, 20);

        var result = calculator.CalculateCost(server);
        
        Assert.Equal(10, result.BandwidthCost);
        Assert.Equal(20, result.ServerCost);
    }

    [Theory]
    [MemberData(nameof(TestObjects))]
    public void PrinterTest(ICostPrinter printer)
    {
        var report = new CostReport(10, 20);
        var lines = printer.Print(report).ToList();
        
        Assert.Equal(2, lines.Count);
        Assert.Equal("Bandwidth: 10", lines[0]);
        Assert.Equal("Server: 20", lines[1]);
    }

    [Fact]
    public void DoubleTest()
    {
        var server = new VirtualServer(ComputeSize.Small, 100, 20);
        var sut = new MixinCalculatorAndPrinter();

        var lines = sut.CostCalcAndPrint.PrintAndCalculate(server).ToList();
        
        Assert.Equal(2, lines.Count);
        Assert.Equal("Bandwidth: 10", lines[0]);
        Assert.Equal("Server: 20", lines[1]);
    }
}