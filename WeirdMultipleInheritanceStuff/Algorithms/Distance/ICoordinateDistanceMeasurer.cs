namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface ICoordinateDistanceMeasurer : IDistanceMeasurer
{
    Coordinate LookupNodeCoordinates(int nodeId);

    int DistanceOfCoordinates(Coordinate from, Coordinate to);
    
    int IDistanceMeasurer.Distance(Node from, Node to)
    {
        var coordinateFrom = LookupNodeCoordinates(from.Id);
        var coordinateTo = LookupNodeCoordinates(to.Id);
        return DistanceOfCoordinates(coordinateFrom, coordinateTo);
    }
}