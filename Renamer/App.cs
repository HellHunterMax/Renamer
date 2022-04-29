using Renamer.Extention;
using Renamer.models;

namespace Renamer
{
    public class App
    {
        private List<Image> _images;
        private readonly string _path;
        private const string _greyPath = @".\grey\";

        public App(string path)
        {
            _path = path;
            var imageFilePaths = Directory.GetFiles(_path);

            if (imageFilePaths.Length == 0)
                throw new Exception("No files found in directory");

            _images = new();
            foreach (var filePath in imageFilePaths)
            {
                _images.Add(new Image(Path.GetFileName(filePath)));
            }
        }

        public void Run()
        {
            Directory.CreateDirectory($"{_path}{_greyPath}");
            foreach (var image in _images)
            {
                File.Copy($"{_greyPath}{image.Size.GetGreyFileName()}", $"{_path}/grey/{image.ImageName}");
            }
        }
    }
}
