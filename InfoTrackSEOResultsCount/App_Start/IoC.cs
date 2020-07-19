using Autofac;
using Autofac.Integration.Mvc;
using InfoTrackSEOResultsCount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfoTrackSEOResultsCount.App_Start
{
    public class IoC
    {
        public static void Configure()
        {           
            var builder = new ContainerBuilder();
            builder.RegisterType<GoogleSearchAdaptor>().AsImplementedInterfaces();            
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();                       
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}