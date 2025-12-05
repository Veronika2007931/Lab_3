using DogClass;
using Decorators;
using InterfaceDog;
using UserClass;
using VideoServiceProxyClass;

namespace ProgramFile
{
   class Program{
    static void Main(string[] args){
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    
    User richUser = new User("Veronika", 100.20m );
    VideoServiceProxy proxy1 = new VideoServiceProxy(richUser);

    proxy1.UploadVideo("MyVocation.mp4");
    proxy1.CreateVideoCatalog();

    User poorUser = new User("Volodymyr", 5.30m);
    VideoServiceProxy proxy2 = new VideoServiceProxy(poorUser);


    proxy2.UploadVideo("MyVocation.mp4");
    proxy2.CreateVideoCatalog();

    
    IDog myDog = new Dog("Рекс", "Вівчарка", 35.5);
    myDog.DisplayInfo();
    myDog.PerformCommands();

    IDog hunter = new Dog("Бім", "Спаніель", 15.0);
     hunter = new HunterDecorator(hunter);
     hunter.DisplayInfo();
    hunter.PerformCommands();

    IDog best = new Dog("Тайсон", "Пітбуль", 28.0);
    best = new FightingDecorator(best);
    best = new ExhibitionFeaturesDecorator(best, "Куповані вуха та хвіст");

   best.DisplayInfo();
   Console.WriteLine("Команди:");
   best.PerformCommands();

   Console.ReadKey();

    
   }

   

        

       
        
   }


}