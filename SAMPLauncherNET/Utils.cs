using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace SAMPLauncherNET
{
    public static class Utils
    {

        public static readonly Size GalleryImageSize = new Size(256, 256);
  
        public static bool AreEqual<T>(T[] a, T[] b)
        {
            bool ret = false;
            if ((a != null) && (b != null))
            {
                if (a.Length == b.Length)
                {
                    ret = true;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (!(a[i].Equals(b[i])))
                        {
                            ret = false;
                            break;
                        }
                    }
                }
            }
            return ret;
        }

        public static void DisposeAll(IDisposable[] list)
        {
            if (list != null)
            {
                foreach (IDisposable i in list)
                {
                    if (i != null)
                        i.Dispose();
                }
            }
        }

        public static Image GetThumb(Image image)
        {
            Bitmap ret = new Bitmap(GalleryImageSize.Width, GalleryImageSize.Height, PixelFormat.Format32bppArgb);
            Size sz = (image.Width >= image.Height) ? new Size(GalleryImageSize.Width, (int)(GalleryImageSize.Width * ((double)(image.Height) / image.Width))) : new Size(GalleryImageSize.Height, (int)(GalleryImageSize.Height * ((double)(image.Width) / image.Height)));
            Graphics g = Graphics.FromImage(ret);
            g.Clear(Color.Transparent);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImage(image, new Rectangle(new Point((GalleryImageSize.Width - sz.Width) / 2, (GalleryImageSize.Height - sz.Height) / 2), sz), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            return ret;
        }
    }
}
