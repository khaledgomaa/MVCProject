using System;
using System.IO;

namespace Models
{
    public static class ImageManager
    {
        private static Random random = new Random();

        public static string UploadFile(string image, string path)
        {
            string base64 = image.Substring(image.IndexOf(',') + 1);
            base64 = base64.Trim('\0');
            byte[] chartData = Convert.FromBase64String(base64);
            string imageName = DateTime.Now.ToString("yymmssfff") + random.Next(255522, 99999999) + ".png";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), Path.Combine(path, imageName));
            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), path)))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllBytes(filePath, chartData);
            return imageName;
        }

        public static string UploadVideo(string image, string path, string name)
        {
            string base64 = image.Substring(image.IndexOf(',') + 1);
            base64 = base64.Trim('\0');
            byte[] chartData = Convert.FromBase64String(base64);
            string imageName = name.Replace(" ", "") + DateTime.Now.ToString("yymmssfff") + random.Next(255522, 99999999) + ".mp4";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), Path.Combine(path, imageName));
            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), path)))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllBytes(filePath, chartData);
            return path + "/" + imageName;
        }

        public static void DeleteFile(string path)
        {
            FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), path));
            if (file.Exists)
            {
                file.Delete();
            }
        }
    }
}