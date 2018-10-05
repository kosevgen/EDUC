using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGKiller.ImgManipulations
{
    class ImageCompressBL
    {
        ImageCodecInfo imageCodecInfo;
        System.Drawing.Imaging.Encoder encoder;
        public ImageCompressBL()
        {
            FileManager.FileManagerBL fileManagerBL = new FileManager.FileManagerBL();
            string[] allFileName = fileManagerBL.AllFileName;
            ImgCompress imgCompress = new ImgCompress();
            imageCodecInfo = imgCompress.GetEncoderInfo("image/jpeg");
            encoder = System.Drawing.Imaging.Encoder.Quality;
            for(int i = 0; i < allFileName.Length; i++)
            {
                //some function for thread or thread run!!!
            }
        }
    }
}
