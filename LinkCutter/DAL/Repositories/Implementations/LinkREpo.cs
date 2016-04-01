using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.DataEntities;

namespace DAL.Repositories.Implementations
{
    public class LinkRepo : BaseRepo, ILinkRepo
    {
        public Link Create(int userId, string url)
        {
            using (var ctx = GetContext())
            {
                var link = new Link { Original = url, UserId = userId };
                ctx.Links.Add(link);
                if (ctx.SaveChanges() > 0)
                    return link;
                else return null;
                

            }
        }

        public Link Get(int id)
        {
            using (var ctx = GetContext())
                return ctx.Links.FirstOrDefault(x => x.Id == id);
        }

        public Link Update(Link link)
        {
            using (var ctx = GetContext())
            {
                ctx.Links.Attach(link);
                ctx.Entry(link).State = System.Data.Entity.EntityState.Modified;
                if (ctx.SaveChanges() > 0)
                    return link;
                else return null;
            }
        }
    }
}
