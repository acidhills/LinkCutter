using Autofac;
using DAL.Repositories.Contracts;
using DAL.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALAutofacModule : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterType<LinkRepo>().As<ILinkRepo>().SingleInstance();
            moduleBuilder.RegisterType<UserRepo>().As<IUserRepo>().SingleInstance();
        }
    }
}
