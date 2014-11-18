using System.Drawing;

namespace MvcApplication.Utility
{
    /// <summary>
    /// 缩略图工具
    /// </summary>
    public class Thumbnaill
    {
        public static void GenerateThumbnaill(string source, string destination, int maxwidth, int maxheight)
        {
            Image orginalImage = Image.FromFile(source);

            int originalWidth = orginalImage.Width;
            int originalHeight = orginalImage.Height;

            int thumbnailWidth, thumbnailHeight;
            Resize(originalWidth, originalHeight, maxheight, maxwidth, out thumbnailWidth, out thumbnailHeight);

            Bitmap bitmap = new Bitmap(thumbnailWidth, thumbnailHeight);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.DrawImage(orginalImage, 0, 0, thumbnailWidth, thumbnailHeight);
            bitmap.Save(destination);
        }

        public static void Resize(int origwidht, int oriHeight, int maxWidth, int maxHeight, out int sizeWidth,
            out int sizedHeight)
        {
            if (origwidht < maxWidth && oriHeight < maxHeight)
            {
                sizeWidth = origwidht;
                sizedHeight = oriHeight;
                return;
            }
            sizeWidth = maxWidth;
            sizedHeight = (int)((double)oriHeight / origwidht * sizeWidth + 0.5);

            if (sizedHeight > maxHeight)
            {
                sizedHeight = maxHeight;
                sizeWidth = (int)((double)origwidht / oriHeight * sizedHeight + 0.5);
            }
        }
    }
}