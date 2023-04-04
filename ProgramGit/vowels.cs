namespace ProgramGit
{
    internal class vowels
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the string:");
                string n = Console.ReadLine();
                string res = "";
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] == 'a' || n[i] == 'e' || n[i] == 'i' || n[i] == 'o' || n[i] == 'u' || n[i] == 'A' || n[i] == 'E' || n[i] == 'I' || n[i] == 'O' || n[i] == 'U')
                    {
                        continue;
                    }
                    else
                    {
                        res += n[i];
                    }
                }
                Console.WriteLine(res);
            }
        
    }
}