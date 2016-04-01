using BL.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL.Repositories.Contracts;
using BL.Mappers;
using Entities.ViewModels;

namespace BL.Services.Implementations
{
    public class LinkService : BaseService, ILinkService
    {
        readonly IUserRepo _userRepo;
        readonly ILinkRepo _linkRepo;
        readonly LinkToVmMaper _linkMapper;
        public LinkService(IUserRepo userRepo, 
                           ILinkRepo linkRepo,
                           LinkToVmMaper linkMapper)
        {
            _userRepo = userRepo;
            _linkRepo = linkRepo;
            _linkMapper = linkMapper;
        }
        public LinkVM Create(int userId, string url)
        {
            return _linkMapper.Map(_linkRepo.Create(userId,url));
        }

        public LinkVM Get(int id)
        {
            return _linkMapper.Map(_linkRepo.Get(id));
        }

        public IEnumerable<LinkVM> GetLinks(int userId)
        {
            var user = _userRepo.Get(userId);
            return user?.Links.Select(_linkMapper.Map);
        }
    }
}
