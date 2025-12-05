using InterfaceDog;
namespace DogClass
{
    public class Dog : IDog
        {
            private string Breed;
            private string Name;
            private double Weight;

            public Dog(string breed, string name, double weight)
            {
                Breed = breed;
                Name = name;
                Weight = weight;

            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Dog {Name} Breed {Breed} Weight{Weight}");
            }
            public void PerformCommands()
        {
            Console.Write(" Базові команди: Сидіти, Лежати, Голос. ");
        }
        }

}