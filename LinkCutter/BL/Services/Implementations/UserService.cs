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
    public class UserService : BaseService, IUserService
    {
        readonly IUserRepo _userRepo;
        readonly UserToVmMaper _userToVmMapper;
        public UserService(IUserRepo userRepo,
                           UserToVmMaper userToVmMapper)
        {
            _userRepo = userRepo;
            _userToVmMapper = userToVmMapper;
        }
        public UserVM Create()
        {
            return _userToVmMapper.Map(_userRepo.Create());
        }
    }
}
