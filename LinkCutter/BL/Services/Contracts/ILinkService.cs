using Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Contracts
{
    public interface ILinkService
    {
        LinkVM Create(int userId, string url);
        LinkVM Get(int id);
        IEnumerable<LinkVM> GetLinks(int userId);
    }
}
