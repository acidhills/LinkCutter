using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkCutter.Controllers.MVC
{
    public class GuiController : BaseController
    {
        // GET: Gui
        public ActionResult Index()
        {
            return View();
        }
    }
}