 
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;
using MvcApplication.Entity;

namespace MvcApplication.Utility
{
    public class FileHelper
    {
        public static List<FileLibrary> GetAllFile()
        {
            string basePath = System.AppDomain.CurrentDomain.BaseDirectory+"\\UploadFiles";

            string[] files = Directory.GetFiles(basePath);
            List<FileLibrary> FileInfos = new List<FileLibrary>();
            int i = 0;
            foreach (var file in files)
            {
                i++;
                FileInfo fileIn=new FileInfo(file);
                FileLibrary fileInfo = new FileLibrary();
                fileInfo.Extension = fileIn.Extension;
                fileInfo.FileLibrary_nbr = i;
                fileInfo.NewFileName = fileIn.Name;
                fileInfo.OldFileName = fileIn.Name;
                FileInfos.Add(fileInfo);
            }
            return FileInfos;
        }
    }
}