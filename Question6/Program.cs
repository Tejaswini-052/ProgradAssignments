namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

           
            char maxChar = '\0';
            int maxCount = 0;

            
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                
                int count = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[j] == c)
                    {
                        count++;
                    }
                }

                
                if (count > maxCount)
                {
                    maxCount = count;
                    maxChar = c;
                }
            }


            Console.WriteLine("The maximum repeated character is : " + maxChar);
            Console.WriteLine("The maximum Count : " + maxCount);
        }
    }
}