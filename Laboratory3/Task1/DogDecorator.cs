
using InterfaceDog;
namespace DogDecoratorClass
{
     public abstract class DogDecorator : IDog
        {
            protected IDog wrappedDog;

            public DogDecorator(IDog dog)
            {
                wrappedDog = dog;
            }

            public virtual void DisplayInfo()
            {
                wrappedDog.DisplayInfo();
            }
            public virtual void PerformCommands()
            {
                wrappedDog.PerformCommands();
            }


        }

}