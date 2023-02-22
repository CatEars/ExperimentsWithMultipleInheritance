namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface IDistanceMeasurer
{
    IDistanceMeasurer Measurer => this;
    
    int Distance(Node from, Node to);
}