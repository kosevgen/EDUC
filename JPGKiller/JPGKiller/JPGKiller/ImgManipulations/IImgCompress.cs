using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace JPGKiller.ImgManipulations
{
    interface IImgCompress
    {
        Image CreateImgFromFile(string fileName);
        ImageCodecInfo GetEncoderInfo(string mimeType);
        EncoderParameters SetEncoderParameters(long quality);
        bool Save(string patch, ImageCodecInfo codecInfo, EncoderParameters encoder);
    }
}
