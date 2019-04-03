﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication7
{
    public class Global : System.Web.HttpApplication
    {
       protected void Application_Start(object sender, EventArgs e)
        {
            
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}