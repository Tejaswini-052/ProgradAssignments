namespace Question3
{
    internal class oddEven
    {
        static void Main(string[] args)
        {
            string even = "";
            string odd = "";
            Console.WriteLine("Enter the String");
            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += n[i];
                }
                else
                {
                    odd += n[i];
                }
            }

            Console.WriteLine(even + " " + odd);

        }
    }
}