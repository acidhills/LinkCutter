using BL.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL.Repositories.Contracts;

namespace BL.Services.Implementations
{
    public class LinkService : BaseService, ILinkService
    {
        readonly IUserRepo _userRepo;
        readonly ILinkRepo _linkRepo;
        public LinkService(IUserRepo userRepo, ILinkRepo linkRepo)
        {
            _userRepo = userRepo;
            _linkRepo = linkRepo;
        }
        public Link Create(int userId)
        {
            return _linkRepo.Create(userId);
        }

        public Link Get(int id)
        {
            return _linkRepo.Get(id);
        }

        public IEnumerable<Link> GetLinks(int userId)
        {
            return _userRepo.Get(userId)?.Links;
        }
    }
}
