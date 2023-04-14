using System.Collections;

namespace Anagram
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string:");
            string[] String1 = new string[size]; 
            for(int iterator = 0; iterator < size; iterator++)
            {
                String1[iterator] = Console.ReadLine();
            }
              Hashtable groups = new Hashtable();

                foreach (string str in String1)
                {
                    char[] chars = str.ToCharArray();
                    Array.Sort(chars);
                    string sortedStr = new string(chars);

                    if (!groups.ContainsKey(sortedStr))
                    {
                        groups[sortedStr] = new Hashtable();
                    }
                    ((Hashtable)groups[sortedStr])[str] = null;
                }

                string[][] result = new string[groups.Count][];
                int i = 0;
                foreach (Hashtable group in groups.Values)
                {
                    string[] arr = new string[group.Count];
                    int j = 0;
                    foreach (string str in group.Keys)
                    {
                        arr[j++] = str;
                    }
                    result[i++] = arr;
                }


            for (int row = 0; row < result.Length; row++)
            {
                for (int col = 0; col < result[row].Length; col++)
                {
                    Console.Write(result[row][col] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}