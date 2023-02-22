namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface DistanceMeasurer : IDistanceMeasuring
{

    IDistanceMeasuring Measuring => this;

}