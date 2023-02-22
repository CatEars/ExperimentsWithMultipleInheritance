namespace WeirdMultipleInheritanceStuff.Algorithms.Distance;

public interface EuclideanCoordinateDistanceMeasurer : ICoordinateDistanceMeasurer
{
    int ICoordinateDistanceMeasurer.DistanceOfCoordinates(Coordinate from, Coordinate to)
    {
        var diffX = from.X - to.X;
        var diffY = from.Y - to.Y;
        var dist = Math.Sqrt(diffX * diffX + diffY * diffY);
        return (int) Math.Floor(dist);
    }
}