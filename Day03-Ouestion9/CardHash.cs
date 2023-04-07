namespace Day03_Ouestion9
{
    internal class CardHash
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the card number:");
                string cardno = Console.ReadLine();
                if (cardno.Length <= 4)
                {
                   Console.WriteLine(cardno); 
        
                }
                else
                {
                    string hashed = "";
                    for (int i = 0; i < cardno.Length - 4; i++)
                    {
                        hashed += "#";
                    }
                    hashed += cardno.Substring(cardno.Length - 4);
                    Console.WriteLine(hashed);
                }

           

        }
    }
}