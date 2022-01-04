namespace SportEvents.Helpers
{
    internal static class ImageHelper
    {
        /// <summary>
        /// Convert the image from the biunary data format to the Image object format
        /// </summary>
        public static Image GetImage(byte[] binaryData)
        {
            if (binaryData.Length == 0)
                return Properties.Resources.baby_yoda;

            return Image.FromStream(new MemoryStream(binaryData));
        }

        public static Image GetImage(Stream imageStream)
        {
            return GetImage(GetBinaryData(imageStream));
        }

        public static byte[] GetBinaryData(Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        private static byte[] GetBinaryData(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using MemoryStream ms = new MemoryStream();
            int read;

            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }
    }
}