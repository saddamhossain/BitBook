using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitBookLoginApp.Models;

namespace BitBookLoginApp.Controllers
{
    public class ImageGalleryController : Controller
    {
        private BitBookDbContext db = new BitBookDbContext();
        //
        // GET: /ImageGallery/
        public ActionResult Index()
        {
            var imagesModel = new ImageGallery();
            var imageFiles = Directory.GetFiles(Server.MapPath("~/Upload_Files/"));
            foreach (var item in imageFiles)
            {
                imagesModel.ImageList.Add(Path.GetFileName(item));
            }
            return View(imagesModel);
        }

        [HttpGet]
        public ActionResult UploadImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadImageMethod()
        {
            if (Request.Files.Count != 0)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase file = Request.Files[i];
                    int fileSize = file.ContentLength;
                    string fileName = file.FileName;
                    file.SaveAs(Server.MapPath("~/Upload_Files/" + fileName));
                    ImageGallery imageGallery = new ImageGallery();
                    imageGallery.ID = Guid.NewGuid();
                    imageGallery.Name = fileName;
                    imageGallery.ImagePath = "~/Upload_Files/" + fileName;
                    db.ImageGalleries.Add(imageGallery);
                    db.SaveChanges();
                }
                return Content("Success");
            }
            return Content("failed");
        }





    }
}









