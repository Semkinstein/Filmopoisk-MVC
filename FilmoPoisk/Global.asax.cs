﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FilmoPoisk.Models;
using System.Data.Entity;

namespace FilmoPoisk
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // DB initialization on app start
            Database.SetInitializer(new DBInitializer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
