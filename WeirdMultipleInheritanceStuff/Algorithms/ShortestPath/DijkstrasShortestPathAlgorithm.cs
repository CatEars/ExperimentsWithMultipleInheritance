using WeirdMultipleInheritanceStuff.Algorithms.Distance;

namespace WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

public interface DijkstrasShortestPathAlgorithm : IShortestPathCalculator, IDistanceMeasurer, ParentPathFind
{
    private static List<int> FindPath(IReadOnlyDictionary<int, int> parent, int elementId)
    {
        var path = new List<int>() { elementId };
        do
        {
            elementId = parent[elementId];
            path.Add(elementId);
        } while (parent[elementId] != -1);
            
        path.Reverse();
        return path;
    }
    
    GraphPath IShortestPathCalculator.CalculateShortestPath(Graph graph, Node start, Node destination)
    {
        var nodeLookup = graph.Nodes.ToDictionary(node => node.Id, node => node);
        var visited = new HashSet<int>();
        var parent = new Dictionary<int, int>();
        var queue = new PriorityQueue<(Node Prior, Node Current), int>();
        queue.Enqueue((new Node(-1, ""), start), 0);
        
        while (queue.TryDequeue(out var nodes, out var distance))
        {
            var (prior, current) = nodes;
            visited.Add(current.Id);
            parent[current.Id] = prior.Id;
            
            if (current.Id == destination.Id)
            {
                var path = FindPathToRootParent(parent, current.Id);
                path.Reverse();
                return new GraphPath(path, distance);
            }

            var neighbors = graph.Edges[current.Id];
            var unvisitedNeighbors = neighbors.Where(neigh => !visited.Contains(neigh));
            foreach (var neigh in unvisitedNeighbors)
            {
                var targetNode = nodeLookup[neigh];
                var fullDistance = distance + Measurer.Distance(current, targetNode);
                queue.Enqueue((current, targetNode), fullDistance);
            }
        }

        throw new Exception("Could not find route");
    }

}