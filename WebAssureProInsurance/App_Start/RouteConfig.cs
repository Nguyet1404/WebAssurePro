using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAssureProInsurance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Newslist",
             url: "news",
             defaults: new { controller = "News", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "WebAssureProInsurance.Controllers" }
         );
            routes.MapRoute(
            name: "DetailsNew",
            url:"{alias}-n{id}",
            defaults: new { controller = "News", action = "Details",id = UrlParameter.Optional },
            namespaces: new[] { "WebAssureProInsurance.Controllers" }
        );
            routes.MapRoute(
                 name: "Contact",
                 url: "contact",
                 defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
                 namespaces: new[] { "WebAssureProInsurance.Controllers" }
            );
            routes.MapRoute(
                name: "CheckOut",
                url: "pay",
                defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
                namespaces: new[] { "WebAssureProInsurance.Controllers" }
           );
            routes.MapRoute(
               name: "ShoppingCart",
               url: "cart",
               defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "WebAssureProInsurance.Controllers" }
          );
            routes.MapRoute(
              name: "CategoryProduct",
              url: "productcategory/{alias}-{id}",
              defaults: new { controller = "Products", action = "ProductCategory", id = UrlParameter.Optional },
              namespaces: new[] { "WebAssureProInsurance.Controllers" }
          );
            routes.MapRoute(
             name: "Detail",
             url: "detail/{alias}-p{id}",
             defaults: new { controller = "Products", action = "Detail", id = UrlParameter.Optional },
             namespaces: new[] { "WebAssureProInsurance.Controllers" }
         );
            routes.MapRoute(
              name: "Product",
              url: "product",
              defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "WebAssureProInsurance.Controllers" }
          );
            routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                    namespaces: new[] { "WebAssureProInsurance.Controllers" } 
            );
        }
    }
}
