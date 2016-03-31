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
        Link Create(int userId);

        Link Get(int id);        
    }
}
