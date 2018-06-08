using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorByNumber.Controllers
{
    public class ColorController : Controller
    {
        // GET: GetColorInfo
        public ActionResult GetColorInfo()
        {
            return View();
        }
    }
}