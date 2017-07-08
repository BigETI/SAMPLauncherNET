using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace SAMPLauncherNET
{
    public static class Utils
    {
        public static System.Drawing.Size galleryImageListSize = new System.Drawing.Size(256, 256);
  
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

        public static Bitmap GetThumb(Image image)
        {
            int w = image.Width;
            int h = image.Height;
            Size thumbSize = galleryImageListSize;
            int tw, th, tx, ty;
            double whRatio = (double)w / (double)h;

            if (image.Width >= image.Height)
            {
                tw = thumbSize.Width;
                th = (int)(tw / whRatio);
            }
            else
            {
                th = thumbSize.Height;
                tw = (int)(th * whRatio);
            }
            tx = (thumbSize.Width - tw) / 2;
            ty = (thumbSize.Height - th) / 2;
            Bitmap thumb = new Bitmap(thumbSize.Width, thumbSize.Height, PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(thumb);
            g.Clear(Color.Transparent);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(image, new Rectangle(tx, ty, tw, th), new Rectangle(0, 0, w, h), GraphicsUnit.Pixel);

            return thumb;
        }
    }
}
