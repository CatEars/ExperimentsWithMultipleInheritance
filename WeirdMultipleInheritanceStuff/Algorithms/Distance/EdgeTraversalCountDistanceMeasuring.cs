namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface EdgeTraversalCountDistanceMeasuring : IDistanceMeasuring
{
    int IDistanceMeasuring.Distance(Node from, Node to)
    {
        return 1;
    }
}