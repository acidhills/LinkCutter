using BL.Services.Contracts;
using Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace LinkCutter.Controllers.API
{
    [RoutePrefix("user/{userId:int}")]
    public class LinkController : BaseApiController
    {
        ILinkService _linkService { get; set; }
        public LinkController(ILinkService linkService) : base()
        {
            _linkService = linkService;
        }
        public Link Post(int userId)
        {
            return _linkService.Create(userId);
        }

        [HttpGet]
        public IEnumerable<Link> Links(int userId)
        {
            return _linkService.GetLinks(userId);
        }
    }
}
