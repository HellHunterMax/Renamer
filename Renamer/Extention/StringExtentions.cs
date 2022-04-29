using Renamer.Enums;

namespace Renamer.Extention
{
    public static class StringExtentions
    {
        public static ImgSize GetImageSize(this string fileName)
        {
            const string n530 = "530";
            const string n800 = "800";
            const string n1180 = "1180";
            const string n2500 = "2500";
            fileName = fileName.Replace(".jpg", "");

            var split = fileName.Split('-');

            if (fileName.Length <= 1)
            {
                throw new ArgumentException("Invalid split from the Name: {0}", fileName);
            }

            return split[1] switch
            {
                n530 => ImgSize.FiveHundredThirty,
                n800 => ImgSize.ElevenHundredAighty,
                n1180 => ImgSize.ElevenHundredAighty,
                n2500 => ImgSize.TwentyFiveHundred,
                _ => throw new ArgumentException("Unable to read Size from the Name: {0}", fileName),
            };
        }
    }
}
