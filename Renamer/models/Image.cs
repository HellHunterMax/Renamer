using Renamer.Enums;
using Renamer.Extention;

namespace Renamer.models
{
    public class Image
    {
        public Image(string imageName)
        {
            ImageName = imageName;
            Size = imageName.GetImageSize();
        }
        public string ImageName { get; set; }
        public ImgSize Size { get; set; }
    }
}
