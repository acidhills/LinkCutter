using BL.Services.Contracts;
using Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace LinkCutter.Controllers.API
{
    [RoutePrefix("api/user/{userId:int}")]
    public class LinkController : BaseApiController
    {
        ILinkService _linkService { get; set; }
        public LinkController(ILinkService linkService) : base()
        {
            _linkService = linkService;
        }
        [Route("link")]
        public Link Post(int userId,[FromBody]string url)
        {
           return _linkService.Create(userId, url);
        }

        [HttpGet]
        [Route("links")]
        public IEnumerable<Link> Links(int userId)
        {
            return _linkService.GetLinks(userId);
        }
    }
}
