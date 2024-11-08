using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBookStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "BookStore", action = "Index", id = UrlParameter.Optional }
                //defaults: new { controller = "Nguoidung", action = "Dangnhap", id = UrlParameter.Optional }
                //defaults: new { controller = "GioHang", action = "Giohang", id = UrlParameter.Optional }
            );
        }
    }
}
