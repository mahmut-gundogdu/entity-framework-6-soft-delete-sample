using SoftDelete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftDelete.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            Db db = new Models.Db();
            //db.Kisiler.Add(new Kisi() {
            //    Ad = "Mahmut",
            //    Soyad = "Gundogdu"
            //});

            var Kisiler = db.Kisiler.ToList();

            db.SaveChanges();
            return View();
        }
    }
}