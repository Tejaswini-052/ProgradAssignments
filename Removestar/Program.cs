namespace RemoveStar
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string StringStarRemove = Console.ReadLine();
            int n = StringStarRemove.Length;
            Stack<char> stack = new Stack<char>();

            
            for (int i = 0; i < n; i++)
            {
                if (StringStarRemove[i] == '*')
                {
                    
                    while (stack.Count > 0 && stack.Peek() == '*')
                    {
                        stack.Pop();
                    }
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(StringStarRemove[i]);
                }
            }

            
            char[] arr = stack.ToArray();
            Array.Reverse(arr);

            
            Console.WriteLine(arr);
        }
    }
}