namespace InterfaceFile
{
    public interface IVideoService
    {
        void UploadVideo(string videoName);
        void CreateVideoCatalog();
        void ProcessVideo(string videoName);
    }

}