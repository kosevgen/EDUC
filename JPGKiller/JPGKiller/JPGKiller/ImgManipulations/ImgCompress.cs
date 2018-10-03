using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encoder = System.Drawing.Imaging.Encoder;

namespace JPGKiller.ImgManipulations
{
    class ImgCompress : IImgCompress
    {
        string[] _allFileNames;
        Encoder _Encoder;
        EncoderParameter _EncoderParameter;
        EncoderParameters _EncoderParameters;
        //fileInfo
        //imageCodecInfo
        //EncoderParameters
        public string[] AllFileNames
        {
            set
            {
                _allFileNames = value;
            }
        }

        public Image CreateImgFromFile(string fileName)
        {
            return Image.FromFile(fileName);
        }

        public bool Save(string patch, ImageCodecInfo codecInfo, EncoderParameters encoder)
        {
            try
            {
                Image img = new Bitmap(patch);
                img.Save(patch, codecInfo, encoder);
                return true;
            }
            catch(Exception exeptionSaveImg)
            {

                return false;
            }
        }

        public EncoderParameters SetEncoderParameters(long quality)
        {
            _EncoderParameters = new EncoderParameters(1);
            _EncoderParameter = new EncoderParameter(_Encoder, quality);
            _EncoderParameters.Param[0] = _EncoderParameter;
            return _EncoderParameters;
        }

        public ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int i;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (i = 0; i < encoders.Length; ++i)
            {
                if (encoders[i].MimeType == mimeType)
                    return encoders[i];
            }
            return null;
        }
        //myImageCodecInfo = GetEncoderInfo("image/jpeg");
    }
}
