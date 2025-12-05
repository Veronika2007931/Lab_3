using DogDecoratorClass;
using InterfaceDog;
namespace Decorators
{
    public class HunterDecorator : DogDecorator
        {
            public HunterDecorator(IDog dog) : base(dog){}

            public override void PerformCommands()
            {
                base.PerformCommands();
               Console.WriteLine("Мисливець: Взяти слід! Принести здобич! ");
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("+ Функція: Мисливська (активний пошук)");
            }
        }

        public class FightingDecorator : DogDecorator
        {
            public FightingDecorator(IDog dog) : base(dog){}

            public override void PerformCommands()
            {
                base.PerformCommands();
                Console.Write("Охоронець: Фас! Ороняти! ");
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
               Console.WriteLine(" + Функція: Охоронна/Бійцівська (висока агресія).");
            }
        }

        public class ExhibitionFeaturesDecorator : DogDecorator
        {
            private string Features;

            public ExhibitionFeaturesDecorator(IDog dog, string features) : base(dog)
            {
                Features = features;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($" + Особливість собаки: {Features}");
            }
        }
}