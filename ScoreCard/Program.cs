namespace ScoreCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number scores need to be entered:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value:");
            string[] value = new string[size];
            for (int iterator = 0; iterator < size; iterator++)
            {
                value[iterator] = Console.ReadLine();
            }
            int[] scores = new int[value.Length];
            int lastValidIndex = -1;
            int sum = 0;
            foreach (string op in value)
            {
                if (op == "C")
                {
                    if (lastValidIndex >= 0)
                    {
                        sum -= scores[lastValidIndex];
                        lastValidIndex--;
                    }
                }
                else if (op == "D")
                {
                    if (lastValidIndex >= 0)
                    {
                        int doubledScore = scores[lastValidIndex] * 2;
                        scores[++lastValidIndex] = doubledScore;
                        sum += doubledScore;
                    }
                }
                else if (op == "+")
                {
                    if (lastValidIndex >= 1)
                    {
                        int sumOfLastTwoScores = scores[lastValidIndex] + scores[lastValidIndex - 1];
                        scores[++lastValidIndex] = sumOfLastTwoScores;
                        sum += sumOfLastTwoScores;
                    }
                }
                else
                {
                    int score = Int32.Parse(op);
                    scores[++lastValidIndex] = score;
                    sum += score;
                }
            }
            Console.WriteLine("Result:" + sum);
        }
    }
}