using WeirdMultipleInheritanceStuff.Algorithms.Distance;

namespace WeirdMultipleInheritanceStuff.Algorithms.Repository;

public interface InMemoryCoordinateNodeRepository :
    InMemoryNodeRepository<CoordinateNode>,
    INodeCoordinateLookup
{
    Coordinate INodeCoordinateLookup.LookupNodeCoordinates(int nodeId)
    {
        return Repo.GetNode(nodeId).Coordinate;
    }
}