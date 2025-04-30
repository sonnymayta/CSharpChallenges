namespace ArrowFactories
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("1. Standar Arrows\n2. Custom Arrows\nEnter de number: ");
            int customArrow = int.Parse(Console.ReadLine() ?? "0");
            Console.Clear();
            Arrow arrow;
            switch (customArrow)
            {
                case 1:
                    Console.WriteLine("Choose a kind of arrow");
                    Console.Write("1. The Elite Arrow\n2. The Beginner Arrow\n3. The Marksman Arrow\nEnter de number: ");
                    int standarArrow = int.Parse(Console.ReadLine() ?? "0");
                    Console.Clear();
                    if (standarArrow == 1)
                    {
                        arrow = Arrow.CreateEliteArrow();
                    }
                    else if (standarArrow == 2)
                    {
                        arrow = Arrow.CreateSBeginnerArrow();
                    }
                    else if (standarArrow == 3)
                    {
                        arrow = Arrow.CreateMarksmanArrow();
                    }
                    else
                    {
                        arrow = Arrow.UndefinedArrow();
                    }
                    break;
                case 2:
                    Console.WriteLine("Choose the part of the arrows");
                    Console.Write("Arrowhead:\n1. Steel\n2. Wood\n3. Obsidian\nEnter de number: ");
                    int arrowHead = int.Parse(Console.ReadLine() ?? "0");
                    Console.Clear();
                    Console.Write("Fletching:\n1. Plastic\n2. Turkey Feather\n3. Goose Feather\nEnter de number: ");
                    int fletching = int.Parse(Console.ReadLine() ?? "0");
                    Console.Clear();
                    Console.Write("Shaft length (cm): ");
                    int shaftLength = int.Parse(Console.ReadLine() ?? "0");
                    Console.Clear();
                    arrow = new((ArrowHead)arrowHead, shaftLength, (Fletching)fletching);
                    break;
                default:
                    arrow = Arrow.UndefinedArrow();
                    break;
            }
            
            Console.WriteLine($"<{arrow.ArrowHead}-{arrow.ShaftLength}cm-{arrow.Fletching}<<");
            Console.WriteLine($"Cost: {arrow.GetCost():n}");
        }
    }

    internal class Arrow
    {
        private ArrowHead _arrowHead;
        private int _shaftLength;
        private Fletching _fletching;

        internal ArrowHead ArrowHead
        {
            get => _arrowHead;
            set => _arrowHead = value;
        }

        internal int ShaftLength
        {
            get => _shaftLength;
            set => _shaftLength = value;
        }

        internal Fletching Fletching
        {
            get => _fletching;
            set => _fletching = value;
        }

        internal Arrow(ArrowHead arrowHead, int shaftLenght, Fletching fletching)
        {
            _arrowHead = arrowHead;
            _shaftLength = shaftLenght;
            _fletching = fletching;
        }

        internal static Arrow CreateEliteArrow()
        {
            return new Arrow(ArrowHead.steel, 95, Fletching.plastic);
        }

        internal static Arrow CreateSBeginnerArrow()
        {
            return new Arrow(ArrowHead.wood, 75, Fletching.gooseFeather);
        }

        internal static Arrow CreateMarksmanArrow()
        {
            return new Arrow(ArrowHead.steel, 65, Fletching.gooseFeather);
        }

        internal static Arrow UndefinedArrow()
        {
            return new Arrow(ArrowHead.undefined, 0, Fletching.undefined);
        }

        internal float GetCost()
        {
            float cost = 0;
            switch (_arrowHead)
            {
                case ArrowHead.steel:
                    cost += 10f;
                    break;
                case ArrowHead.wood:
                    cost += 3f;
                    break;
                case ArrowHead.obsidian:
                    cost += 5f;
                    break;
                default:
                    break;
            }
            switch (_fletching)
            {
                case Fletching.plastic:
                    cost += 10f;
                    break;
                case Fletching.turkeyFeather:
                    cost += 5f;
                    break;
                case Fletching.gooseFeather:
                    cost += 3f;
                    break;
                default:
                    break;
            }
            cost += _shaftLength * 0.05f;
            return cost;
        }
    }

    enum ArrowHead
    {
        undefined,
        steel,
        wood,
        obsidian
    }

    enum Fletching
    {
        undefined,
        plastic,
        turkeyFeather,
        gooseFeather,
    }
}
