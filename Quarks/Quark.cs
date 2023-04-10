namespace Quarks
{
    public class Quark
    {
        public string Color;
        public string Flavor;
        public double BaryonNumber;

        public Quark(string color, string flavor)
        {
            this.Color = color;
            this.Flavor = flavor;
            this.BaryonNumber = 1.0/ 3.0;
        }

        public void Display()
        {
            Console.WriteLine(Color +" "+  Flavor +" "+BaryonNumber);
        }
        public void Interact(Quark OtherQuark)
        {
            string temp = this.Color;
            this.Color = OtherQuark.Color;
            OtherQuark.Color = temp;
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine("Before calling interact method:");
            Quark quarkObject1 = new Quark("Yellow", "up");
            quarkObject1.Display();

            Quark quarkObject2 = new Quark("Orange", "strange");
            quarkObject2.Display();

            Console.WriteLine("After calling interact method:");
            quarkObject1.Interact(quarkObject2);
            quarkObject1.Display();
            quarkObject2.Display();
        }
    }
}