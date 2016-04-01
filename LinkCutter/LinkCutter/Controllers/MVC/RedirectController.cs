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
        ILinkStatisticService _linkStatisticService;
        public RedirectController(ILinkService linkService,
                                  ILinkStatisticService linkStatisticService)
        {
            _linkService = linkService;
            _linkStatisticService = linkStatisticService;
        }
        // GET: Redirect
        public ActionResult Index(int linkId)
        {
            var link = _linkService.Get(linkId);
            if (link != null && !string.IsNullOrWhiteSpace(link.originalUrl))
            {
                _linkStatisticService.IncrementLinkStat(linkId);
                return Redirect(new UriBuilder(link.originalUrl).Uri.ToString());
            }
            throw new Exception("Нет такой урлы");
        }
    }
}