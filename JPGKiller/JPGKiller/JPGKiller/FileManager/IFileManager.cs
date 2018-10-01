using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGKiller.FileManager
{
    interface IFileManager
    {
        string GetFolderPatch();
        string[] GetAllFileNames(string patch);
        double GetFileSize(string fileName);
        double GetAllFilesSize(string[] AllFileNames);
        int GetDeltaCompressImage();
    }
}
