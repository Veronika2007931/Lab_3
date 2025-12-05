using InterfaceFile;

namespace VideoServiceClass{
    public class VideoService : IVideoService
    {
        public void UploadVideo(string videoName)
        {
            Console.WriteLine($"Відео  '{videoName}' успішно завантажено на сервер");
        }   

        public void CreateVideoCatalog()
        {
            Console.WriteLine("Створення відеокаталогу... Готово!");
        }

        public void ProcessVideo(string videoName)
        {
            Console.WriteLine($"Відео '{videoName}' успішно оброблене");
        }
    }
}