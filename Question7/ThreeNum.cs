namespace Question7
{
    internal class ThreeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter begin number");
            int beg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End number");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Step number");
            int step = int.Parse(Console.ReadLine());

            if (beg > end)
            {
                Console.WriteLine("0");
            }

            int res = 0;
            int i = beg;
            while (i <= end)
            {
                res += i;
                i += step;
            }

            Console.WriteLine(res);

        }
    }
}