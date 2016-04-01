using DAL.EF;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class BaseRepo
    {        
        protected LinkCutterDataContext GetContext()
        {
            return new LinkCutterDataContext("name=LinkCutterDBConnectionString");
        }
    }
}
