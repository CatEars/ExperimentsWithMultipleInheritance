namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface ICoordinateDistanceMeasuring : IDistanceMeasuring
{
    Coordinate LookupNodeCoordinates(int nodeId);

    int DistanceOfCoordinates(Coordinate from, Coordinate to);
    
    int IDistanceMeasuring.Distance(Node from, Node to)
    {
        var coordinateFrom = LookupNodeCoordinates(from.Id);
        var coordinateTo = LookupNodeCoordinates(to.Id);
        return DistanceOfCoordinates(coordinateFrom, coordinateTo);
    }
}