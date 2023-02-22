namespace WeirdMultipleInheritanceStuff.Algorithms.Repository;

public interface INodeRepository<TNodeType> where TNodeType : Node
{

    void AddNode(TNodeType node);

    TNodeType GetNode(int nodeId);

    void AddNodes(IEnumerable<TNodeType> nodes)
    {
        foreach (var node in nodes) AddNode(node);
    }
    
}