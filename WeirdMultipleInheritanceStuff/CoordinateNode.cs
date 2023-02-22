namespace WeirdMultipleInheritanceStuff;

public record CoordinateNode(int Id, Coordinate Coordinate, string Name="") : Node(Id, Name);