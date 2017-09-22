using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Utility class
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Gallery image size
        /// </summary>
        public static readonly Size GalleryImageSize = new Size(256, 256);
  
        /// <summary>
        /// Are arrays equal
        /// </summary>
        /// <typeparam name="T">Array type</typeparam>
        /// <param name="a">Left hand array</param>
        /// <param name="b">Right hand array</param>
        /// <returns></returns>
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

        /// <summary>
        /// Dispose all
        /// </summary>
        /// <param name="list">List</param>
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

        /// <summary>
        /// Get thumbnail
        /// </summary>
        /// <param name="image">Image</param>
        /// <returns>Thumbnail</returns>
        public static Image GetThumbnail(Image image)
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
