using System;
using System.IO;
using System.Drawing;

namespace Base64_image_test
{
    class Program
    {
        public bool SaveImage(string imgStr, string imgName)
        {
            string path = "D://My_Files//SofwareCareerPath//Dotnet Development//C#//Base64-image-test//Base64-image-test//image";
            string imageName = imgName + ".jpg";

            string imgPath = Path.Combine(path, imageName);

            byte[] imageBytes = Convert.FromBase64String(imgStr);
            File.WriteAllBytes(imgPath, imageBytes);

            return true;
        }

        private static bool isImageSave(string imgStr, string imageName = "save.jpg")
        {
            string path = "D://My_Files//SofwareCareerPath//Dotnet Development//C#//Base64-image-test//Base64-image-test//image";
            string uploadFile = Path.Combine(path, "test.PNG");
            string imgSavePath = Path.Combine(path, imageName);
            var tempFile = Path.GetTempPath();
            Console.WriteLine(tempFile);


            // Converting  an image into a string to byte
            byte[] imageArray = System.IO.File.ReadAllBytes(uploadFile);
            string base64ImageRespresentation = Convert.ToBase64String(imageArray);
            Console.WriteLine(base64ImageRespresentation);
            byte[] bytes = Convert.FromBase64String(base64ImageRespresentation);

            //using(MemoryStream ms = new MemoryStream(bytes))
            //{

            //}
            //File.WriteAllBytes(imgSavePath, bytes);
            return true;
        }
        static void Main(string[] args)
        {
            string path = "D://My_Files//SofwareCareerPath//Dotnet Development//C#//Base64-image-test//Base64-image-test//image";
            string uploadFile = Path.Combine(path, "test.PNG");
            string imageName = "save.jpg";
            string imgSavePath = Path.Combine(path, imageName);

            // Converting  an image into a string to byte
            byte[] imageArray = System.IO.File.ReadAllBytes(uploadFile);
            string base64ImageRespresentation = Convert.ToBase64String(imageArray);
            Console.WriteLine(base64ImageRespresentation);
            byte[] bytes = Convert.FromBase64String(base64ImageRespresentation);

            //using(MemoryStream ms = new MemoryStream(bytes))
            //{

            //}
            File.WriteAllBytes(imgSavePath, bytes);

            Console.ReadKey();
        }
    }
}
