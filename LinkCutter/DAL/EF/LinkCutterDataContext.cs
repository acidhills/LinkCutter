using DAL.EF.EntityConfigurations;
using Entities;
using Entities.DataEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class LinkCutterDataContext : DbContext
    {
        
        public LinkCutterDataContext(string connection): base(connection)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("link_cutter");
            modelBuilder.Configurations.Add(new LinkConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

       public DbSet<User> Users { get; set; }   
       public DbSet<Link> Links { get; set; }
    }
}
