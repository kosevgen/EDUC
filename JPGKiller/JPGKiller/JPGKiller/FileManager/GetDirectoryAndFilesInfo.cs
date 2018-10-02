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
        private string[] allFileNames = System.IO.Directory.GetFiles(DirectoryPath, "*.JPG|*.jpg");
        private static string DirectoryPath = Directory.GetCurrentDirectory();
        private readonly string CompressedImgDirectoryPath = Directory.GetCurrentDirectory() + "\\Пожовані";
        private int fileCount;
        private int compressionLevel;

        public GetDirectoryAndFilesInfo()
        {
            MessageSent message = new MessageSent();
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

        //private int GetCountFile(String dirPath)//
        //{
        //    int b = Directory.GetFiles(dirPath, "*.JPG").Length;
        //    Messages.MessageForm messageFromFileCount = new Messages.MessageForm("All file count is + " + b.ToString(), "1", (float)16.0, "Courier New");
        //    messageFromFileCount.Show();
        //    return b;
        //}

        //private void CalcCompressionLevel(long allSize, byte imgCount)//
        //{
        //    compressionLevel = (int)(GetDeltaCompressImage(allSize) * 100);
        //    Messages.MessageForm messageFromCompressLevel = new Messages.MessageForm("All file compress + "+compressionLevel.ToString(), "0", (float)16.0, "Courier New");
        //    messageFromCompressLevel.Show();
        //}

        //private double GetDeltaCompressImage(long allSize)//
        //{
        //    if (allSize > 15 * 1024 * 1024)
        //    {
        //        return (1 - (constSizeForMailSystem / allSize) + 0.1);
        //    }
        //    else if (allSize <= 15 * 1024 * 1024)
        //    {
        //        return 0.000;
        //    }
        //    else
        //    {
        //        //messeg somsing bad hepen
        //        return 4.9999;
        //    }
        //}

        //private long GetFileSize(string fullFileName)//
        //{
        //    return new FileInfo(fullFileName).Length;
        //}

        //private long GetAllImageSize(int arrayImageNumber, string[] allFileNames)//var!!!
        //{
        //    long size = 0;
        //    for (int i = 0; i < arrayImageNumber; i++)
        //    {
        //        size += GetFileSize(allFileNames[i]);
        //    }
        //    Messages.MessageForm messageFromAllImageSize = new Messages.MessageForm("All files size  work + "+size.ToString(), "0", (float)16.0, "Courier New");
        //    messageFromAllImageSize.Show();
        //    return size;
        //}

        //public bool CreatCompressFolder()// 
        //{
        //    try
        //    {
        //        Directory.CreateDirectory(CompressedImgDirectoryPath);
        //        Messages.MessageForm messageFromAllImageSize = new Messages.MessageForm("New folder create + " + CompressedImgDirectoryPath, "0", (float)16.0, "Courier New");
        //        messageFromAllImageSize.Show();
        //        return true;
        //    }
        //    catch(Exception dirCreateException)
        //    {
        //        //message error;
        //        return false;
        //    }
            
        //}

        //public void RunFileManager()
        //{
        //    long sizeAllImg;
        //    fileCount = GetCountFile(DirectoryPath);
        //    sizeAllImg = GetAllImageSize(fileCount, this.allFileNames);
        //    CalcCompressionLevel(sizeAllImg, (byte)fileCount);
        //    CreatCompressFolder();
        //}
    }
}
