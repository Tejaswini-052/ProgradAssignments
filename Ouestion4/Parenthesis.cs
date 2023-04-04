namespace Ouestion4
{
    internal class Parenthesis
    {
        static void Main(string[] args)
        {
            string res = " ";
            int j = 0;
            Console.WriteLine("Enter  string");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    j += 1;
                }
                else if (c == ')')
                {
                    j -= 1;
                }
                else if (j == 0)
                {
                    res += c;
                }
            }
            Console.WriteLine(res);

        }
    }
}