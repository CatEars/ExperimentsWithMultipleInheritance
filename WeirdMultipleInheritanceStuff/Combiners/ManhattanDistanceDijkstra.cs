using WeirdMultipleInheritanceStuff.Algorithms.Distance;
using WeirdMultipleInheritanceStuff.Algorithms.Repository;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

namespace WeirdMultipleInheritanceStuff.Combiners;

public class ManhattanDistanceDijkstra : 
    DijkstrasShortestPathAlgorithm, 
    ManhattanCoordinateDistanceMeasurer,
    InMemoryCoordinateNodeRepository
{
    public List<CoordinateNode> Nodes { get; } = new();
    
}