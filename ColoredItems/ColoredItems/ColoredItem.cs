namespace ColoredItems
{
    internal class ColoredItem<T>
    {
        public T Item { get; }
        public ConsoleColor Color { get; }

        public ColoredItem(T item, ConsoleColor color)
        {
            Item = item;
            Color = color;
        }

        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Item);
        }
    }
}
