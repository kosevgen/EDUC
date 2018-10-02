using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGKiller.FileManager
{
    class FileManagerBL
    {
        byte _countFile;
        string[] _allFileNames;
        long _allFileSize;
        byte _compressionLevel;

        public byte CountFile
        {
            get
            {
                return _countFile;
            }
        }
        public string[] AllFileName
        {
            get
            {
                return _allFileNames;
            }
        }
        public long AllFileSize
        {
            get
            {
                return _allFileSize;
            }
        }
        public byte CompressionLevel
        {
            get
            {
                return _compressionLevel;
            }
        }

        public FileManagerBL()
        {
            GetDirectoryAndFilesInfo filesInfo = new GetDirectoryAndFilesInfo();
            _countFile = (byte)filesInfo.GetCountFile(filesInfo.CurrentDirectoryPath);
            _allFileNames = filesInfo.AllFileNames;
            _allFileSize = filesInfo.GetAllImageSize(_countFile, _allFileNames);
            if (ifFileSize(_allFileSize, filesInfo.SizeForMail))
            {
                _compressionLevel = filesInfo.CalcCompressionLevel(_allFileSize, _countFile);
                filesInfo.CreatCompressFolder(filesInfo.CommpressedImageDirectory);
                Messages.MessageForm messageFromBL = new Messages.MessageForm("Size images is " + _allFileSize + "this is compress");
            }
            else
            {
                Messages.MessageForm messageFromBL = new Messages.MessageForm("Size images is " + _allFileSize + "this not compress");
            }
        }

        bool ifFileSize(long fSize, int maxSize)
        {
            if (fSize <= maxSize)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
