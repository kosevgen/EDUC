using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPGKiller.Messages;

namespace JPGKiller.FileManager
{
    class GetDirectoryAndFilesInfo
    {
        private const int constSizeForMailSystem = 15_728_640;
        private string[] allFileNames = Directory.GetFiles(DirectoryPath, "*.JPG");
        private static string DirectoryPath = Directory.GetCurrentDirectory();
        private string CompressedImgDirectoryPath = Directory.GetCurrentDirectory() + "\\Пожовані";
        private int compressionLevel;

        public GetDirectoryAndFilesInfo()
        {
            
        }

        public string[] AllFileNames
        {
            get
            {
                return allFileNames;
            }
        }
        public string CurrentDirectoryPath
        {
            get
            {
                return DirectoryPath;
            }
        }
        public string CommpressedImageDirectory
        {
            get
            {
                return CompressedImgDirectoryPath;
            }
        }
        public int SizeForMail
        {
            get
            {
                return constSizeForMailSystem;
            }
        }
        public int CompressionLevel
        {
            get
            {
                return compressionLevel;
            }
        }

        byte fileCount = (byte)Directory.GetFiles(DirectoryPath, "*.JPG").Length;

        public int GetCountFile(String dirPath)//
        {
            int count = Directory.GetFiles(dirPath, "*.JPG").Length;
            Messages.MessageForm messageFromFileCount = new Messages.MessageForm("All file count is + " + count.ToString(), "1", (float)16.0, "Courier New");
            messageFromFileCount.Show();
            return count;
        }

        public byte CalcCompressionLevel(long allSize, byte imgCount)//
        {
            return (byte)(GetDeltaCompressImage(allSize) * 100);
        }

        private double GetDeltaCompressImage(long allSize)//
        {
            if (allSize > 15 * 1024 * 1024)
            {
                return (1 - (constSizeForMailSystem / allSize) + 0.1);
            }
            else if (allSize <= 15 * 1024 * 1024)
            {
                return 0.000;
            }
            else
            {
                //messeg somsing bad hepen
                return 4.9999;
            }
        }

        protected long GetFileSize(string fullFileName)//
        {
            return new FileInfo(fullFileName).Length;
        }

        public long GetAllImageSize(byte arrayImageNumber, string[] allFileNames)//var!!!
        {
            long size = 0;
            for (int i = 0; i < arrayImageNumber; i++)
            {
                size += GetFileSize(allFileNames[i]);
            }
            Messages.MessageForm messageFromAllImageSize = new Messages.MessageForm("All files size  work + " + size.ToString(), "0", (float)16.0, "Courier New");
            messageFromAllImageSize.Show();
            return size;
        }

        public bool CreatCompressFolder(string DirPath)// 
        {
            try
            {
                Directory.CreateDirectory(DirPath);
                Messages.MessageForm messageFromAllImageSize = new Messages.MessageForm("New folder create + " + DirPath, "0", (float)16.0, "Courier New");
                messageFromAllImageSize.Show();
                return true;
            }
            catch (Exception dirCreateException)
            {
                //message error;
                return false;
            }

        }

        //protected void RunFileManager()
        //{
        //    long sizeAllImg;
        //    sizeAllImg = GetAllImageSize(fileCount, this.allFileNames);
        //    CalcCompressionLevel(sizeAllImg, (byte)fileCount);
        //    CreatCompressFolder(DirectoryPath);
        //}
    }
}
