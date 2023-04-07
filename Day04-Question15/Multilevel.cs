namespace Day04_Question15
{
    internal class Block
    {

        public class Shape
        {
            public void Display()
            {
                Console.WriteLine("There are different shapes");
            }
        }

        public class Triangle : Shape
        {
            public void Draw()
            {
                Console.WriteLine("Triangle have three sides");
            }
        }

        class Equilateral : Triangle
        {
            public void sides()
            {
                Console.WriteLine("All sides are equal");
            }
        }


        static void Main(string[] args)
        {
            Equilateral Trial = new Equilateral();
            Trial.Display();
            Trial.sides();
            Trial.Draw();

        }

    }
}