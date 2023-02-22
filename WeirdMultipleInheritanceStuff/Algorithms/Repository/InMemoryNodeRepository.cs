namespace WeirdMultipleInheritanceStuff.Algorithms.Repository;

public interface InMemoryNodeRepository<TNodeType> : INodeRepository<TNodeType> where TNodeType : Node
{
    List<TNodeType> Nodes { get; }

    void INodeRepository<TNodeType>.AddNode(TNodeType node)
    {
        Nodes.Add(node);
    }

    TNodeType INodeRepository<TNodeType>.GetNode(int nodeId)
    {
        return Nodes.First(node => node.Id == nodeId);
    }
}