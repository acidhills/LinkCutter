using Entities;
using Entities.DataEntities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public class LinkToVmMapper : IVmMapper<Link,LinkVM>
    {
        readonly string _baseUrl;
        public LinkToVmMapper(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public LinkVM Map(Link link)
        {
            return new LinkVM
            {
                shortUrl = _baseUrl + link.Id,
                originalUrl = link.Original,
                visitors = link.Visitors,
                created = link.Created.ToString("dd-MM-yyyy")
            };
        }
    }
}
