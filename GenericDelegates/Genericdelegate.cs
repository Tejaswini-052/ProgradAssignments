namespace GenericDelegates
{
    public class Genericdelegate
    {
        static void Main(string[] args)
        {
            //Action delegate
            List<string> names = new List<string> { "Tejaswini", "Swathi", "Shalini" };
            Action<List<string>> printNames = (list) => {
                foreach (string word in list)
                {
                    Console.WriteLine(word);
                }
            };

            printNames(names);

            //Func delegate
            Func<double, double, double> RectangleArea = (length, width) => length * width;
            double area = RectangleArea(10.5, 20.5);
            Console.WriteLine(area);

            //Predicate delegate
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);

            static bool IsUpperCase(string str)
            {
                return str.Equals(str.ToUpper());
            }
        }
    }
}