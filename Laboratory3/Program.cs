using InterfaceFile;
using UserClass;
using VideoServiceProxyClass;

namespace ProgramFile
{
   class Program{
    static void Main(string[] args){
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    User richUser = new User("Veronika", 100.20m );
    VideoServiceProxy proxy1 = new VideoServiceProxy(richUser);

    proxi1.UploadVideo("MyVocation.mp4");
    proxi1.CreateVideoCatalog();

    User poorUser = new User("Volodymyr", 5.30m);
    VideoServiceProxy proxy2 = new VideoServiceProxy(poorUser);


    proxi2.UploadVideo("MyVocation.mp4");
    proxi2.CreateVideoCatalog();

    Console.ReadKey();

   }
   }


}