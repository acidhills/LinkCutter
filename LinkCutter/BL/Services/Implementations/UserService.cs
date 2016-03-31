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
    public class UserService : BaseService, IUserService
    {
        readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public User Create()
        {
            return _userRepo.Create();
        }
    }
}
