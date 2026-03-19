namespace EnteringTheCatacombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[2];
            Console.Title = "Entering the Catacombs";
            Console.WriteLine("Entering the Catacombs!");

            points[0] = new Point(2, 3);
            points[1] = new Point(-4, 0);

            Console.WriteLine($"Point 1: {points[0]}");
            Console.WriteLine($"Point 2: {points[1]}");

            TheColor hotColor = new(200, 200, 0);
            Console.WriteLine($"HotColor {hotColor}");
            TheColor coldColor = TheColor.Blue;
            Console.WriteLine($"ColdColor {coldColor}");

            Card goodCard = new(Card.CardColor.Red, Card.Rank.One);
            Console.WriteLine($"GoodCard {goodCard} a {goodCard.GetCardType()}");

            Card awesomeCard = new(Card.CardColor.Green, Card.Rank.Dollar);
            Console.WriteLine($"AwesomeCard {awesomeCard} a {awesomeCard.GetCardType()}");
            
            List<Card> deck = CreateDeck();

            foreach (Card card in deck)
            {
                Console.WriteLine($"{card} a {card.GetCardType()}");
            }
        }

        public static List<Card> CreateDeck()
        {
            List<Card> deck = new List<Card>();
            Card.CardColor color;

            for (int i = 0; i < 4; i++)  //Make a loop for all colors
            {
                switch (i)  //change the card color each iteration of i
                {
                    case 0:
                        color = Card.CardColor.Red;
                        break;
                    case 1:
                        color = Card.CardColor.Green;
                        break;
                    case 2:
                        color = Card.CardColor.Blue;
                        break;
                    default:
                        color = Card.CardColor.Yellow;
                        break;
                }

                for (int j = 0; j < 14; j++) //make a loop for all cards within each color
                {
                    Card.Rank rank = (Card.Rank)j;
                    Card card = new Card(color, rank);  //create the card with the color and rank
                    deck.Add(card);  //add the card to the deck
                }
            }
            return deck;
        }
    }
}
