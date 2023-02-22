using WeirdMultipleInheritanceStuff.Algorithms.Distance;

namespace WeirdMultipleInheritanceStuff.Algorithms.Repository;

public interface InMemoryCoordinateNodeRepository : 
    InMemoryNodeRepository<CoordinateNode>, 
    ICoordinateDistanceMeasurer
{
    Coordinate ICoordinateDistanceMeasurer.LookupNodeCoordinates(int nodeId)
    {
        return Repo.GetNode(nodeId).Coordinate;
    }
}