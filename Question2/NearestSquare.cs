namespace Question2
{
    internal class NearestSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(n);
            int lowerSq = sqrt * sqrt;
            int upperSq = (sqrt + 1) * (sqrt + 1);
            if (n == lowerSq || n == upperSq)
            {
                Console.WriteLine(n);
                Console.WriteLine(Math.Sqrt(lowerSq));
            }
            else if (n < (lowerSq + upperSq) / 2)
            {
                Console.WriteLine(lowerSq);
                Console.WriteLine(Math.Sqrt(lowerSq));
            }
            else
            {
                Console.WriteLine(upperSq);
                Console.WriteLine(Math.Sqrt(upperSq));
            }
        }
    }
}