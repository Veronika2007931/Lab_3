
namespace VideoServiceFile
{
    public interface IVideoService
    {
        void UploadVideo(string videoName);
        void CreateVideoCatalog();
        void ProcessVideo(string videoName);
    }

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

    public class User
    {
        public string Name {get; set;}
        public decimal MoneyAmount {get; set;}

        public User(string name, decimal moneyAmount)
        {
            Name = name;
            MoneyAmount = moneyAmount;
        }
    }
    public class VideoServiceProxy : IVideoService
    {
        private VideoService _videoService;
        public User _user;

        public VideoServiceProxy(User user)
        {
            _user = user;
        }
        private VideoService GetService()
        {
            if(_videoService == null)
            {
                _videoService = new VideoService();
            }
            return _videoService;
        }
        private bool CheckAccess()
        {
            if(_user.MoneyAmount > 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Недостатньо коштів для виконання операції");
                return false;
            }
        }
        
        public void UploadVideo(string videoName)
        {
            if (CheckAccess())
            {
                Console.WriteLine($"Доступ дозволено для {_user.Name}.");
                GetService().UploadVideo(videoName);
            }
        }

        public void CreateVideoCatalog()
        {
            if (CheckAccess()){
                Console.WriteLine($" Доступ дозволено для {_user.Name}.");
                GetService().CreateVideoCatalog();

            }
        }

        public void ProcessVideo(string videoName)
        {
            if (CheckAccess())
            {
                Console.WriteLine($" Доступ дозволено для {_user.Name}.");
                GetService().ProcessVideo(videoName);
            }
        }

    }
}