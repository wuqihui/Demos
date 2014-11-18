using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Entity
{
    public class FileLibrary
    {
        public int FileLibrary_nbr { get; set; }
        public string OldFileName { get; set; }
        public string NewFileName { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public DateTime UploadTime { get; set; }
    }
}