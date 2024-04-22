using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cmsyasix.Core.Convertors
{
    public class ImageToBinary
    {
        public byte[] ImgToBinary(string imagePath)
        {
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, (int)fileStream.Length);
            fileStream.Close();
            return buffer;
        }
    }
}
