using WeirdMultipleInheritanceStuff.Algorithms.Distance;
using WeirdMultipleInheritanceStuff.Algorithms.Repository;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

namespace WeirdMultipleInheritanceStuff.Combiners;

public class EdgeCountDijkstra : 
    DijkstrasShortestPathAlgorithm, 
    EdgeTraversalCountDistanceMeasurer,
    InMemoryNodeRepository<Node>
{
    public List<Node> Nodes { get; } = new();
    
}