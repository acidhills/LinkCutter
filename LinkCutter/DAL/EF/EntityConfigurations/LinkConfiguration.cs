using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.EntityConfigurations
{
    public class LinkConfiguration : EntityTypeConfiguration<Link>
    {
        public LinkConfiguration()
        {
            ToTable("Link");
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
