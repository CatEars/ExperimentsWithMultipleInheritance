# Experiments with multiple inheritance in C#

See the folder [WeirdMultipleInheritanceStuff](./WeirdMultipleInheritanceStuff).

![A memetic image with skeletor in it that says "The logic in this repository is composed only using interfaces" in the first slide with a picture of skeletor dumping some uncomfortable facts from a comfortable position while in the second slide he is running away saying "Skeletor will be back next time with more disturbin commits"](./Skeletor.png)

These are the only three classes in the project:

```csharp
public class EdgeCountDijkstra : 
    DijkstrasShortestPathAlgorithm, 
    EdgeTraversalCountDistanceMeasurer,
    InMemoryNodeRepository<Node>
{
    public List<Node> Nodes { get; } = new();
}

public class EuclideanDistanceDijkstra :
    DijkstrasShortestPathAlgorithm,
    InMemoryCoordinateNodeRepository,
    EuclideanCoordinateDistanceMeasurer
{
    public List<CoordinateNode> Nodes { get; } = new();
}

public class ManhattanDistanceDijkstra : 
    DijkstrasShortestPathAlgorithm, 
    ManhattanCoordinateDistanceMeasurer,
    InMemoryCoordinateNodeRepository
{
    public List<CoordinateNode> Nodes { get; } = new();
}
```

They all implement [Dijkstra's algorithm](https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm), albeit with different definitions of "distance between nodes".

Yes, I am just as confused as you probably are.
