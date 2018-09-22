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
        private int countFile;
        private string[] fileArray;
        private double[] fileSizeAray;
        private double fileMedianaSize;
        private string DirectoryPath = Directory.GetCurrentDirectory();
        private int allImagesSizeInByte;
        private int compressionLevel;
        //pathDic, allImagesSize, Mediana, compressionLevel in %,

        public GetDirectoryAndFilesInfo()
        {
            
        }
        public void GetDeltaCompressImage()
        {
            //((bit)allsize - 15*1024*1024)/img.count
            //delta/mediana=%fromimgsize+10%Errors
        }

        public double GetFileInfo(string fullFileName)
        {
            return (new System.IO.FileInfo(fullFileName).Length)/ 1048576;//in MB!!!
        }

        public string[] GetFolderInfo(String dirPath)
        {
            return System.IO.Directory.GetFiles(dirPath, "*.jpg");
        }

        public int GetCountFile(String dirPath)
        {
            return Directory.GetFiles(dirPath, "*.jpg").Length;
        } 

        public void GetMedianaFileSize()
        {
            
        }

        public struct jpgInfo
        {
            public string dirJpgAddress;
            public int compressionLevel;
            public string dirCompressedJpgAddress(string dirPath)
            {
                return "dirPath + \\Пожовані";
            }
        }

    }
}
