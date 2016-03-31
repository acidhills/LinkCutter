using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Contracts
{
    public interface ILinkService
    {
        Link Create(int userId);
        Link Get(int id);
        IEnumerable<Link> GetLinks(int userId);
    }
}
