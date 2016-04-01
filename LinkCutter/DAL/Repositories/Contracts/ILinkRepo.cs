using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public interface ILinkRepo
    {
        Link Create(int userId, string url);

        Link Get(int id);

        Link Update(Link link);       
    }
}
