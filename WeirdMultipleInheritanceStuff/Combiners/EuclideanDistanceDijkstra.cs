using WeirdMultipleInheritanceStuff.Algorithms.Distance;
using WeirdMultipleInheritanceStuff.Algorithms.Repository;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

namespace WeirdMultipleInheritanceStuff.Combiners;

public class EuclideanDistanceDijkstra :
    DijkstrasShortestPathAlgorithm,
    InMemoryCoordinateNodeRepository,
    EuclideanCoordinateDistanceMeasurer
{
    public List<CoordinateNode> Nodes { get; } = new();
}