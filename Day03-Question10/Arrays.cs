namespace Day03_Question10
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string with comma separated");
            string start = Console.ReadLine();
            string[] strarr = start.Split(" ");
            int mark = 0;
            for (int i = 0; i < (strarr.Length) - 1; i++)
            {
                string string2 = "";
                string string3 = "";
                char end = '\0';
                char Begin = '\0';
                string2 = strarr[i];
                string3 = strarr[i + 1];
                end = string2[(string2.Length) - 1];
                Begin = string3[0];
                Console.WriteLine(Begin);
                Console.WriteLine(end);
                if (end.Equals(Begin))
                {
                    mark = 0;
                }
                else
                {
                    mark = 1;
                }
            }
            if (mark == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}