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
            ImgCompress imgCompress = new ImgCompress();
            imageCodecInfo = imgCompress.GetEncoderInfo("image/jpeg");
            encoder = System.Drawing.Imaging.Encoder.Quality;

        }
    }
}
