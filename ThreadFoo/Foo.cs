namespace ThreadFoo
{
    public class Foo
    {

        public static void first()
        {

            Console.WriteLine("first");

        }

        public static void second()
        {


            Console.WriteLine("second");

        }

        public static void third()
        {

            Console.WriteLine("third");
        }



        static void Main(string[] args)
        {
            int count = 1;
            int[] n = new int[3];
            Console.WriteLine("Enter the Order for three methods:");
            for (int i = 0; i < 3; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            Thread ObjOne = new Thread(first);
            Thread ObjTwo = new Thread(second);
            Thread ObjThree = new Thread(third);
            

            while (n[0] == 1 && n[1] == 2)
            {
               
                ObjOne.Start();
                count = 2;
                if (count == 2)
                {
                    ObjTwo.Start();
                    count = 3;
                }
                if (count == 3)
                {
                    ObjThree.Start();
                }
                n[0] = 4;
            }

            while (n[0] == 2 && n[1] == 3)
            {
               
                ObjTwo.Start();
                count = 2;
                if (count == 2)
                {
                    ObjThree.Start();
                    count = 3;
                }
                if (count ==3)
                {
                    ObjOne.Start();
                }
                n[0] = 4;
            }

            while (n[0] == 3 && n[1] == 1)
            {
               
                ObjThree.Start();
                count = 2;
                if (count == 2)
                {
                    ObjOne.Start();
                    count = 3;
                }
                if  (count ==3 )
                {
                    ObjTwo.Start();
                }
                n[0] = 4;
            }

            while (n[0] == 3 && n[1] == 2)
            {
               
                ObjThree.Start();
                count = 2;
                if (count == 2)
                {
                    ObjTwo.Start();
                    count = 3;
                }
                if (count == 3)
                {
                    ObjOne.Start();
                }
                n[0] = 4;
            }

            while (n[0] == 2 && n[1] == 1)
            {
                
                ObjTwo.Start();
                count = 2;
                if (count == 2)
                {
                    ObjOne.Start();
                    count = 3;
                }
                if (count == 3)
                {
                    ObjThree.Start();
                }
                n[0] = 4;
            }










        }





    }
}
