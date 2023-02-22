using WeirdMultipleInheritanceStuff.Algorithms.Distance;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

namespace WeirdMultipleInheritanceStuff.Combiners;

public class EdgeCountDijkstra : 
    AbstractNodeHolder<Node>,
    DijkstrasShortestPathAlgorithm, 
    EdgeTraversalCountDistanceMeasurer {}