namespace Interval
{
    public class interval
    {
        static void Main(string[] args)
        {
            int[][] IntervalNumbers = new int[][] {
            new int[] {1, 3},
            new int[] {2, 6},
            new int[] {8, 10},
            new int[] {15, 19}
        };
            List<int[]> Combine = new List<int[]>();

                foreach (int[] value in IntervalNumbers)
                {
                    int i = 0;
                    while (i < Combine.Count && value[0] > Combine[i][1])
                    {
                        i++;
                    }
                    while (i < Combine.Count && value[1] >= Combine[i][0])
                    {
                         value[0] = Math.Min(value[0], Combine[i][0]);
                         value[1] = Math.Max(value[1], Combine[i][1]);
                    Combine.RemoveAt(i);
                    }
                
                   Combine.Insert(i, value);
                }

            foreach (int[] item in Combine)
            {
                Console.WriteLine("[" + item[0] + ", " + item[1] + "]");
            }
        }

        }
}
