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
        }
    }
}
