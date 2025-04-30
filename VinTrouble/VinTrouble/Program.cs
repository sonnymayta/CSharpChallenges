namespace VinTrouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Arrow arrow = new((ArrowHead)arrowHead, shaftLength, (Fletching)fletching);
            Console.WriteLine($"<{arrow.GetArrowHead}-{arrow.GetShaftLength}-{arrow.GetFletching}<<");
            Console.WriteLine($"Cost: {arrow.GetCost():n}");
        }
    }
    internal class Arrow
    {
        private readonly ArrowHead _arrowHead;
        private readonly int _shaftLength;
        private readonly Fletching _fletching;

        internal Arrow(ArrowHead arrowHead, int shaftLenght, Fletching fletching)
        {
            _arrowHead = arrowHead;
            _shaftLength = shaftLenght;
            _fletching = fletching;
        }

        internal string GetArrowHead() => $"{_arrowHead}";

        internal string GetShaftLength() => $"{_shaftLength} cm";

        internal string GetFletching() => $"{_fletching}";

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
