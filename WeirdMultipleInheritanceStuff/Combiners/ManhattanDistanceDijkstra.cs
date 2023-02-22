using WeirdMultipleInheritanceStuff.Algorithms.Distance;
using WeirdMultipleInheritanceStuff.Algorithms.Repository;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

namespace WeirdMultipleInheritanceStuff.Combiners;

public class ManhattanDistanceDijkstra :
    AbstractNodeHolder<CoordinateNode>,
    DijkstrasShortestPathAlgorithm,
    ManhattanCoordinateDistanceMeasurer,
    InMemoryCoordinateNodeRepository {}