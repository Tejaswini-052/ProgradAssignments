namespace Day04_Question13
{
    internal class CharacterCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            while (str.Length > 0)
            {
                Console.Write(str[0] + " : ");
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();

        }
    }
}