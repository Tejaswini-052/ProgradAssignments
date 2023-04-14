namespace PartialMethod
{
    public class partialmethod
    {
        public partial class Prograd
        {
            partial void NumberOfstudents(int value);

            public void CallNumberOfstudents()
            {

                NumberOfstudents(5);
            }
        }
        public partial class Prograd
        {

            partial void NumberOfstudents(int value)
            {
                Console.WriteLine("Number of students in prograd are: " + value);
            }
        }
        static void Main(string[] args)
        {

            Prograd StudentObj = new Prograd();
            StudentObj.CallNumberOfstudents();
        }
    }
}