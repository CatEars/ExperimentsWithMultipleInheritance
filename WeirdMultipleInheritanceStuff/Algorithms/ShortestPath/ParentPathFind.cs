namespace WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;

public interface ParentPathFind
{
    List<int> FindPathToRootParent(IReadOnlyDictionary<int, int> parent, int elementId)
    {
        var path = new List<int>() { elementId };
        do
        {
            elementId = parent[elementId];
            path.Add(elementId);
        } while (parent[elementId] != -1);
            
        return path;
    }
}