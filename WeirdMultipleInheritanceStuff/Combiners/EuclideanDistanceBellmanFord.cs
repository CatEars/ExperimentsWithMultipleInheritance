using WeirdMultipleInheritanceStuff.Algorithms.Distance;
using WeirdMultipleInheritanceStuff.Algorithms.Repository;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

namespace WeirdMultipleInheritanceStuff.Combiners;

public class EuclideanDistanceBellmanFord :
    AbstractNodeHolder<CoordinateNode>,
    BellmanFordShortestPathAlgorithm,
    InMemoryCoordinateNodeRepository,
    EuclideanCoordinateDistanceMeasurer {}