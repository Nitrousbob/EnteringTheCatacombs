using System.Reflection.Metadata;

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

            string? code; //grab a code for the door prior to trying the door out.
            do
            {
                Console.WriteLine("Create a passcode for the door.");
                code = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(code) || code.Length != 5 || !code.All(char.IsDigit));
            
            Door door = new Door("BigDoor", Door.DoorState.Closed, code);
            door.DoorMenu(door);
        }

        public static List<Card> CreateDeck() //create the deck with some nested for loops
        {
            List<Card> deck = new List<Card>();  //create the list we are going to send back
            Card.CardColor color;

            for (int i = 0; i < 4; i++)  //Make a loop for all colors  (hardcoded size of loop) better match enum
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
                        color = Card.CardColor.Yellow;  //what if I want to change the size of the enum and be flexible
                        break;
                }

                for (int j = 0; j < 14; j++) //make a loop for all cards within each color
                {
                    Card.Rank rank = (Card.Rank)j;
                    Card card = new Card(color, rank);  //create the card with the color and rank
                    deck.Add(card);  //add the card to the deck
                }
            }
            return deck;  //send the deck back after its created
        }

        public static List<Card> KreateDeck() //alternate version with less code using foreach
        {
            List<Card> deck = new List<Card>();  //create the list we are going to send back

            foreach (Card.CardColor color in Enum.GetValues(typeof(Card.CardColor))) //use the size of CardColors to make the loop iterate
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))  //use the size of Ranks enum to make the loop iterate
                {
                    //bottom of the nest
                    Card card = new Card(color, rank);  //make a new card here during each iteration
                    deck.Add(card); //add the new card to the list
                }
            }
            return deck;  //send the deck back after its created
        }
    }
}
