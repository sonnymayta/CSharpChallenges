namespace TheFountainOfObjects
{
    public struct Position(int row, int column)
    {
        public int Row { get; set; } = row;
        public int Column { get; set; } = column;

        public override string ToString()
        {
            return $"Row={Row}, Column={Column}";
        }
    }
}
