﻿#pragma warning disable 1591
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WidgetTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            Response.Redirect("/ErrorPage/ErrorMessage");
        }
    }
}
