using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace DiemDanh.Controllers
{
    [EnableCors("*","*","*")]
    public class DiemDanhController : Controller
    {
        // GET: DiemDanh
        public ActionResult Index()
        {
            return View();
        }
    }
}