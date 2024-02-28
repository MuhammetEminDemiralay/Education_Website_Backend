using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helper
{
    public static class ImageHelper
    {
        static string directory = Directory.GetCurrentDirectory() + @"\Education\";
        static string pathImage = @"\Images\";
        static string pathVideo = @"\Videoes\";

        public static string Add(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);
            string newFileName = Guid.NewGuid().ToString("N") + extension;

            if (!Directory.Exists(directory + pathImage))
            {
                Directory.CreateDirectory(directory + pathImage);
            }

            if (!Directory.Exists(directory + pathVideo))
            {
                Directory.CreateDirectory(directory + pathVideo);
            }




            using (FileStream fileStream = File.Create(directory + ((extension == ".jpeg" || extension == ".png") ? pathImage : pathVideo) + newFileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }



            return (pathImage + newFileName).Replace("\\", "/"); ;
        }
    }
}
