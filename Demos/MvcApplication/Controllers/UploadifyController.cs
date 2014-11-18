using System; 
using System.IO; 
using System.Web;
using System.Web.Mvc;
using MvcApplication.Utility;

namespace MvcApplication.Controllers
{
    /// <summary>
    /// 这是一个使用uploadify上传文件的demos
    /// </summary>
    public class UploadifyController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult UploadFile(HttpPostedFileBase fileData)
        {
            if (fileData != null && fileData.ContentLength > 0)
            {
                try
                {
                    string fileSavaFolder = Server.MapPath("~/UploadFiles/");
                    if (!Directory.Exists(fileSavaFolder))
                    {
                        Directory.CreateDirectory(fileSavaFolder);
                    }
                    string oleName = fileData.FileName;
                    string extName = Path.GetExtension(fileData.FileName);
                    string newName = Guid.NewGuid() + extName;

                    string fileType = fileData.ContentType;
                    int size = fileData.ContentLength;
                    fileData.SaveAs(Path.Combine(fileSavaFolder, newName));

                    //信息保存到数据库
                    //FileLibrary fl = new FileLibrary();
                    //fl.OldFileName = oleName;
                    //fl.NewFileName = newName;
                    //fl.Extension = extName;
                    //fl.Size = size;

                    //FileLibraryEntity fle = new FileLibraryEntity();
                    //fle.Insert(fl);
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return Content("");
        }

        public ActionResult ViewUploadPhoto()
        {
            return View();
        }

        public JsonResult GetAllUploadFile()
        {
            var model = FileHelper.GetAllFile();
            return Json(model, JsonRequestBehavior.AllowGet);

        }

        public ContentResult GetThumbnailImage(string fileName)
        {
            string oImgUrl = "~/UploadFiles/" + fileName;
            string extName = Path.GetExtension(fileName);
            string newName = Guid.NewGuid().ToString() + extName;
            string nImagUrl = "~/Temp/" + newName;

            Thumbnaill.GenerateThumbnaill(Server.MapPath(oImgUrl), Server.MapPath(nImagUrl), 96, 96);
            string htmltag = "<img id=\"img1\" src=\"/temp/" + newName + "\"/>";
            return Content(htmltag);
        }

        public ContentResult GetImage(string fileName)
        {
            string htmltag = "<img id=\"img1\" src=\"/UploadFiles/" + fileName + "\"/>";
            return Content(htmltag);
        }
    }
}
