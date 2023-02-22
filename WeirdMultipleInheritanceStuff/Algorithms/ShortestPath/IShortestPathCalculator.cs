namespace WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

public interface IShortestPathCalculator
{
    GraphPath CalculateShortestPath(Graph graph, Node start, Node destination);
}