using BL.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkCutter.Controllers.MVC
{
    public class RedirectController : BaseController
    {
        ILinkService _linkService; 
        public RedirectController(ILinkService linkService)
        {
            _linkService = linkService;
        }
        // GET: Redirect
        public ActionResult Index(int linkId)
        {
            var link = _linkService.Get(linkId);
            if (link != null && !string.IsNullOrWhiteSpace(link.Original))
                return Redirect(new UriBuilder(link.Original).Uri.ToString());
            throw new Exception("Нет такой урлы");
        }
    }
}