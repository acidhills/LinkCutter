﻿using Autofac;
using BL.Mappers;
using BL.Services.Contracts;
using BL.Services.Implementations;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLAutofacModule: Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterModule<DALAutofacModule>();
            moduleBuilder.Register(x =>new LinkToVmMaper("http://localhost:58170/")).AsSelf().SingleInstance();
            moduleBuilder.RegisterType<UserToVmMaper>().AsSelf().SingleInstance();
            moduleBuilder.RegisterType<LinkService>().As<ILinkService>().SingleInstance();
            moduleBuilder.RegisterType<UserService>().As<IUserService>().SingleInstance();
            moduleBuilder.RegisterType<LinkStatisticService>().As<ILinkStatisticService>().SingleInstance();
        }
    }
}
