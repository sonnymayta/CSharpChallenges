namespace RoomCoordinates
{
    struct Coordinate
    {
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public static bool AreAdjacent (Coordinate a, Coordinate b)
        {
            int rowChange = a.Row - b.Row;
            int columnChange = a.Column - b.Column;

            if (Math.Abs(rowChange) <= 1 && columnChange == 0) return true;
            if (Math.Abs(columnChange) <= 1 && rowChange == 0) return true;
            return false;
        }
    }
}
