# Experiments with multiple inheritance in C#

See the folder [WeirdMultipleInheritanceStuff](./WeirdMultipleInheritanceStuff).

![A memetic image with skeletor in it that says "The logic in this repository is composed only using interfaces" in the first slide with a picture of skeletor dumping some uncomfortable facts from a comfortable position while in the second slide he is running away saying "Skeletor will be back next time with more disturbin commits"](./Skeletor.png)

These are the only four classes (one abstract) in the project:

```csharp
public abstract class AbstractNodeHolder<TNodeType> : 
    InMemoryNodeRepository<TNodeType> where TNodeType : Node
{
    public List<TNodeType> Nodes { get; } = new();
}

public class EdgeCountDijkstra : 
    AbstractNodeHolder<Node>,
    DijkstrasShortestPathAlgorithm, 
    EdgeTraversalCountDistanceMeasurer {}

public class EuclideanDistanceBellmanFord :
    AbstractNodeHolder<CoordinateNode>,
    BellmanFordShortestPathAlgorithm,
    InMemoryCoordinateNodeRepository,
    EuclideanCoordinateDistanceMeasurer {}

public class ManhattanDistanceDijkstra :
    AbstractNodeHolder<CoordinateNode>,
    DijkstrasShortestPathAlgorithm,
    ManhattanCoordinateDistanceMeasurer,
    InMemoryCoordinateNodeRepository {}
```

They implement [Dijkstra's algorithm](https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm) or the [Bellman-Ford algorithm](https://en.wikipedia.org/wiki/Bellman%E2%80%93Ford_algorithm), albeit with different definitions of "distance between nodes".

As far as I can tell, I've maximised code re-use in this project.

Yes, I am just as confused as you probably are.
