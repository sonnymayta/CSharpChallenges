namespace TheColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color random = new Color(255, 10, 40);
            Color fixedColor = Color.Red;
            Console.WriteLine($"R={random.R} G={random.G} B={random.B}");
            Console.WriteLine($"R={fixedColor.R} G={fixedColor.G} B={fixedColor.B}");
        }
    }

    internal class Color
    {
        internal int R { get; set; }

        internal int G { get; set; }

        internal int B { get; set; }

        internal Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        internal static Color White { get; } = new Color(255, 255, 255);

        public static Color Black { get; } = new Color(0, 0, 0);

        public static Color Red { get; } = new Color(255, 0, 0);

        public static Color Orange { get; } = new Color(255, 165, 0);

        public static Color Yellow { get; } = new Color(255, 255, 0);

        public static Color Green { get; } = new Color(0, 128, 0);

        public static Color Blue { get; } = new Color(0, 0, 255);

        public static Color Purple { get; } = new Color(128, 0, 128);
    }
}
