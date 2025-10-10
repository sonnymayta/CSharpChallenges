using RoomCoordinates;

Coordinate a = new Coordinate(3, 3);
Coordinate b = new Coordinate(2, 3);
Coordinate c = new Coordinate(2, 2);

Console.WriteLine(Coordinate.AreAdjacent(a, b));
Console.WriteLine(Coordinate.AreAdjacent(b, c));
Console.WriteLine(Coordinate.AreAdjacent(a, c));