namespace ZeroEvenOdd
{
    public class ZeroEvenOdd
    {
        private int n;
        private int current;
        private object lockObject = new object();

        public ZeroEvenOdd(int n)
        {
            this.n = n;
            this.current = 1;
        }

        // Prints 0
        public void Zero(Action<int> printNumber)
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (current > n) return;
                    printNumber(0);
                    current++;
                }
            }
        }

        // Prints even numbers
        public void Even(Action<int> printNumber)
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (current > n) return;
                    if (current % 2 == 0)
                    {
                        printNumber(current);
                        current++;
                    }
                }
            }
        }

        // Prints odd numbers
        public void Odd(Action<int> printNumber)
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (current > n) return;
                    if (current % 2 == 1)
                    {
                        printNumber(current);
                        current++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 6; // or any other positive integer
            ZeroEvenOdd zeroEvenOdd = new ZeroEvenOdd(n);

            Action<int> printNumber = (x) => Console.Write(x);

            // Create three threads, one for each method of ZeroEvenOdd
            Thread threadA = new Thread(() => zeroEvenOdd.Zero(printNumber));
            Thread threadB = new Thread(() => zeroEvenOdd.Even(printNumber));
            Thread threadC = new Thread(() => zeroEvenOdd.Odd(printNumber));

            // Start the threads
            threadA.Start();
            threadB.Start();
            threadC.Start();

            // Wait for the threads to complete
            threadA.Join();
            threadB.Join();
            threadC.Join();

            Console.WriteLine(); // Print a newline at the end
        }
    }
}