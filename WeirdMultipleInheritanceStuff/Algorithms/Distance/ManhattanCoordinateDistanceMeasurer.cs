namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface ManhattanCoordinateDistanceMeasurer : ICoordinateDistanceMeasurer
{
    int ICoordinateDistanceMeasurer.DistanceOfCoordinates(Coordinate from, Coordinate to)
    {
        var diffX = from.X - to.X;
        var diffY = from.Y - to.Y;
        return Math.Abs(diffX) + Math.Abs(diffY);
    }
}