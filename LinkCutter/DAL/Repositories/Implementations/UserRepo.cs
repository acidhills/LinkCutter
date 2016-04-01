using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
using Entities.DataEntities;

namespace DAL.Repositories.Implementations
{
    public class UserRepo : BaseRepo, IUserRepo
    {
        public User Create()
        {
            using (var ctx = GetContext())
            {
                var user = new User();
                ctx.Users.Add(user);
                if(ctx.SaveChanges() > 0)
                    return user;
                else return null;
            }
        }

        public User Get(int id)
        {
            using (var ctx = GetContext())
            {
                return ctx.Users.Include(x => x.Links).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
