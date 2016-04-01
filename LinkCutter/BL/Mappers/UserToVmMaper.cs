using Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public class UserToVmMaper
    {
        public UserVM Map(User user)
        {
            return new UserVM
            {
                id = user.Id
            };
        }
    }
}
