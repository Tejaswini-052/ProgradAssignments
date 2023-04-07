namespace Day04_Question12
{
    internal class StringNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string:");
            string[] arr = new string[size];
            int sum = 0;
            int j = 0;
            for (int iterator = 0; iterator < size; iterator++)
            {
                arr[iterator] = Console.ReadLine();
                
            }
             for(int iterator = 0; iterator < size; iterator++)
            {
                
                    if (arr[iterator][j] == '0'|| arr[iterator][j] == '1'|| arr[iterator][j] == '2'|| arr[iterator][j] == '3'|| arr[iterator][j] == '4'|| arr[iterator][j] == '5'|| arr[iterator][j] == '6'|| arr[iterator][j] == '7'|| arr[iterator][j] == '8'|| arr[iterator][j] == '9')
                    {
                        sum += Convert.ToInt32(arr[iterator]);
                    }
            }
            Console.WriteLine(sum);

        }

        }
}