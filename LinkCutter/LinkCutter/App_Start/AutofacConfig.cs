using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace LinkCutter.App_Start
{
    public static class AutofacConfig
    {
        public static void Build()
        {

            var builder = new ContainerBuilder();
            builder.RegisterModule<BLAutofacModule>();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var config = GlobalConfiguration.Configuration;
            builder.RegisterWebApiFilterProvider(config);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}