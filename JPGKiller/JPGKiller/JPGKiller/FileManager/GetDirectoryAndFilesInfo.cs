using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGKiller.FileManager
{
    class GetDirectoryAndFilesInfo 
    {
        GetDirectoryAndFilesInfo()
        {

        }
        public void GetDeltaCompressImage()
        {
            throw new NotImplementedException();
        }

        public double GetFileInfo(string fullFileName)
        {
            return (new System.IO.FileInfo(fullFileName).Length)/ 1048576;//in MB!!!
        }

        public string[] GetFolderInfo()
        {
           return System.IO.Directory.GetFiles(@"c:\JPG", "*.jpg");
        }

        public void GetMedianaFileSize()
        {
            throw new NotImplementedException();
        }
    }
}
