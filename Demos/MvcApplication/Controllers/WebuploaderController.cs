using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class WebuploaderController : Controller
    {
        //
        // GET: /Webuploader/

        public ContentResult UploadPic(HttpPostedFileBase file)
        {
            return new ContentResult();
        }

        public ActionResult Demo()
        {
            return View();
        }
    }
}
