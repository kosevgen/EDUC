using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace JPGKiller.ImgManipulations
{
    interface IImgCompress
    {
        Image CreateImgFromFile(string fileName);
        ImageCodecInfo SetImageEncoder();
        EncoderParameters SetEncoderParameters();
        bool Save(Image img, string patch, ImageCodecInfo codecInfo, EncoderParameters encoder);
    }
}
