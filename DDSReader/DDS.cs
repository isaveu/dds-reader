using System.Drawing;
using System.IO;

namespace AndBurn.DDSReader
{
    /// <summary>
    /// This is the main class of the library.  All static methods are contained within.
    /// </summary>
    public static class DDS
    {
        /// <summary>
        /// Loads a DDS image from a byte array, and returns a Bitmap object of the image.
        /// </summary>
        /// <param name="data">The image data, as a byte array.</param>
        /// <param name="alpha">Preserve the alpha channel or not. (default: true)</param>
        /// <returns>The Bitmap representation of the image.</returns>
        public static Bitmap LoadImage(byte[] data, bool alpha = true)
        {
            DDSImage im = new DDSImage(data);
            im.PreserveAlpha = alpha;
            return im.BitmapImage;
        }

        /// <summary>
        /// Loads a DDS image from a file, and returns a Bitmap object of the image.
        /// </summary>
        /// <param name="file">The image file.</param>
        /// <param name="alpha">Preserve the alpha channel or not. (default: true)</param>
        /// <returns>The Bitmap representation of the image.</returns>
        public static Bitmap LoadImage(string file, bool alpha = true)
        {
            byte[] data = File.ReadAllBytes(file);
            DDSImage im = new DDSImage(data);
            im.PreserveAlpha = alpha;
            return im.BitmapImage;
        }

        /// <summary>
        /// Loads a DDS image from a Stream, and returns a Bitmap object of the image.
        /// </summary>
        /// <param name="stream">The stream to read the image data from.</param>
        /// <param name="alpha">Preserve the alpha channel or not. (default: true)</param>
        /// <returns>The Bitmap representation of the image.</returns>
        public static Bitmap LoadImage(Stream stream, bool alpha = true)
        {
            DDSImage im = new DDSImage(stream);
            im.PreserveAlpha = alpha;
            return im.BitmapImage;
        }
    }
}