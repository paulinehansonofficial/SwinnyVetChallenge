using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using SwinnyVetAPI.Models;
using SwinnyVetAPI.Migrations;
using SwinnyVetAPI.DAL;

namespace SwinnyVetAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer<SwinnyVetContext>(new VetInitialiser());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SwinnyVetContext, Configuration>());
            using (var context = new SwinnyVetContext())
            {
                context.Database.Initialize(false);
            }

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
