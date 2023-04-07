namespace Day04_Question14
{
    internal class multpleInheritance
    {
        interface IWalk
        {
            void Walk();
        }

        interface ISwim
        {
            void Swim();
        }

        class Animal : IWalk, ISwim
        {
            public Animal(string name)
            {
                Console.WriteLine($"Animal {name} has been created");
            }

            public void Walk()
            {
                Console.WriteLine("Animal is walking");
            }

            public void Swim()
            {
                Console.WriteLine("Animal is swimming");
            }
        }

        static void Main(string[] args)
        {
            Animal animal = new Animal("Nemo");
            animal.Walk();
            animal.Swim();
        }

    }

 }
