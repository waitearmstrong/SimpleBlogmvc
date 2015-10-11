using SimpleBlogMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlogMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(PostsController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Login", "Login", new { Controller = "Auth", action = "Login" }, namespaces);
            routes.MapRoute("Home", "", new { Controller = "Posts", action = "Index" }, namespaces);
        }
    }
}
