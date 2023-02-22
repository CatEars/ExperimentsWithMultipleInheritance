namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface EdgeTraversalCountDistanceMeasurer : IDistanceMeasurer
{
    int IDistanceMeasurer.Distance(Node from, Node to)
    {
        return 1;
    }
}