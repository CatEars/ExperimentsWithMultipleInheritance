using WeirdMultipleInheritanceStuff.Algorithms.Repository;

namespace WeirdMultipleInheritanceStuff.Combiners;

public abstract class AbstractNodeHolder<TNodeType> : 
    InMemoryNodeRepository<TNodeType> where TNodeType : Node
{
    public List<TNodeType> Nodes { get; } = new();
}