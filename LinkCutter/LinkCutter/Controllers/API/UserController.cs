using BL.Services.Contracts;
using Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkCutter.Controllers.API
{
    public class UserController: BaseApiController
    {
        IUserService _userService { get; set; }
        public UserController(IUserService userService) : base()
        {
            _userService = userService;
        }
        public UserVM Post()
        {
            return _userService.Create();
        }
    }
}