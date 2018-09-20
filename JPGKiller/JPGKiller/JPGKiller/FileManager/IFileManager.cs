using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGKiller.FileManager
{
    interface IFileManager
    {
        void GetFolderInfo();
        void GetFileInfo();
        void GetMedianaFileSize();
        void GetDeltaCompressImage();
    }
}
