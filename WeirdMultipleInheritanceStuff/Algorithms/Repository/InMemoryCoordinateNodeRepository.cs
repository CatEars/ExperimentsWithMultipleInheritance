using WeirdMultipleInheritanceStuff.Algorithms.Distance;

namespace WeirdMultipleInheritanceStuff.Algorithms.Repository;

public interface InMemoryCoordinateNodeRepository : 
    InMemoryNodeRepository<CoordinateNode>, 
    ICoordinateDistanceMeasurer
{
    Coordinate ICoordinateDistanceMeasurer.LookupNodeCoordinates(int nodeId)
    {
        INodeRepository<CoordinateNode> SelfAsRepo() => this;
        return SelfAsRepo().GetNode(nodeId).Coordinate;
    }
}