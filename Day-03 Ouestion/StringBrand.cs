namespace Day_03_Ouestion
{
    internal class StringBrand
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string stringbrand = Console.ReadLine();

            if (stringbrand.Length > 1 && stringbrand[0] == stringbrand[stringbrand.Length - 1])
            {
                Console.WriteLine(stringbrand.Substring(0, 1).ToUpper() + stringbrand.Substring(1) + stringbrand.ToLower());
            }
            else
            {
                Console.WriteLine("The " + stringbrand.Substring(0, 1).ToUpper() + stringbrand.Substring(1).ToLower());
            }
        }
    }
}