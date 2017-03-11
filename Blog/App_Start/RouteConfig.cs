using Blog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(PostsController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute("Login", "login", new { controller = "Authentification", action = "Login" }, namespaces);  

            routes.MapRoute("Index","",new { controller = "Posts", action = "Index" }, namespaces);
        }
    }
}
