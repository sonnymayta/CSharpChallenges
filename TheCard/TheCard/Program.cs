using System.Drawing;

namespace TheCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color[] colors = [Color.red, Color.green, Color.blue, Color.yellow];
            Rank[] ranks = [Rank.one, Rank.two, Rank.three, Rank.four, Rank.five, Rank.six, Rank.seven, Rank.eight, Rank.nine, Rank.ten, Rank.dollarSign, Rank.percent, Rank.caret, Rank.ampersand];

            foreach (Color color in colors)
            {
                foreach (Rank rank in ranks)
                {
                    Card card = new Card(rank, color);
                    Console.WriteLine($"The {card.Color} {card.Rank}");
                }
            }
        }
    }

    internal class Card
    {
        public Rank Rank { get; }

        public Color Color { get; }

        public Card(Rank rank, Color color)
        {
            Rank = rank;
            Color = color;
        }

        public bool IsSymbol => Rank == Rank.ampersand || Rank == Rank.caret || Rank == Rank.dollarSign || Rank == Rank.percent;

        public bool IsNumber => !IsSymbol;
    }

    internal enum Color
    {
        undefined,
        red,
        green,
        blue,
        yellow
    }

    internal enum Rank
    {
        undefined,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        dollarSign,
        percent,
        caret,
        ampersand,
    }
}
