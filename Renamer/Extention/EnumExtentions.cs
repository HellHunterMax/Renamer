using Renamer.Enums;

namespace Renamer.Extention
{
    public static class EnumExtentions
    {
        public static string GetGreyFileName(this ImgSize size)
        {
            return size switch
            {
                ImgSize.FiveHundredThirty => @"grey-530.jpg",
                ImgSize.EightHundred => @"grey-800.jpg",
                ImgSize.ElevenHundredAighty => @"grey-1180.jpg",
                ImgSize.TwentyFiveHundred => @"grey-2500.jpg",
                _ => throw new ArgumentException("Invalid ImgSize")
            };
        }
    }
}
