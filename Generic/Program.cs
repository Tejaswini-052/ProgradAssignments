namespace Generic
{
    internal class Program
    {

        static void Main(string[] args)
        {

            GenericClass<string> gen = new GenericClass<string>("I am generic class");
            GenericClass<int> genI = new GenericClass<int>(101);
            GenericClass<char> getCh = new GenericClass<char>('I');

            //GenericMethod
            GenericMethod genMethod = new GenericMethod();
            genMethod.Display("I am generic method");
            genMethod.Display(101);
            genMethod.Display('I');
        }
        
    }
}