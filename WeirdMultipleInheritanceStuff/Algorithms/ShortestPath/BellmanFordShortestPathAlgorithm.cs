using WeirdMultipleInheritanceStuff.Algorithms.Distance;

namespace WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

public interface BellmanFordShortestPathAlgorithm : IShortestPathCalculator, IDistanceMeasurer, ParentPathFind
{
    GraphPath IShortestPathCalculator.CalculateShortestPath(Graph graph, Node start, Node destination)
    {
        const int inf = int.MaxValue;
        var nodeLookup = graph.Nodes.ToDictionary(node => node.Id, node => node);
        var distances = graph.Nodes.ToDictionary(node => node.Id, _ => inf);
        var parent = new Dictionary<int, int>();
        parent[start.Id] = -1;
        distances[start.Id] = 0;
        var cardinality = graph.Nodes.Count;
        for (var x = 0; x < cardinality; ++x)
        {
            foreach (var originNode in graph.Edges.Keys)
            {
                var origin = nodeLookup[originNode];

                foreach (var edgeConnectedNode in graph.Edges[originNode])
                {
                    var originDist = distances[originNode];
                    if (originDist == inf) continue;
                    var targetDist = distances[edgeConnectedNode];
                    var target = nodeLookup[edgeConnectedNode];
                    var distance = Measurer.Distance(origin, target);
                    var possiblyNewDist = originDist + distance;
                    if (targetDist == inf || possiblyNewDist < targetDist)
                    {
                        parent[target.Id] = origin.Id;
                        distances[target.Id] = possiblyNewDist;
                    }
                }
            }
        }

        if (distances[destination.Id] == inf)
        {
            throw new Exception("No route to destination");
        }

        var path = FindPathToRootParent(parent, destination.Id);
        path.Reverse();
        var fullDistance = distances[destination.Id];
        return new GraphPath(path, fullDistance);
    }
}