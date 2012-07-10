using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace testsite
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Random", "Random", new { controller = "Home", action = "SleepRandom" });
            routes.MapRoute("RouteOne", "RouteOne", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteTwo", "RouteTwo", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteThree", "RouteThree", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteFour", "RouteFour", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteFive", "RouteFive", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteSix", "RouteSix", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteSeven", "RouteSeven", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteEight", "RouteEight", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteNine", "RouteNine", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("RouteTen", "RouteTen", new { controller = "Home", action = "SleepRandom", min = 0, max = 10 });
            routes.MapRoute("Sleep", "TwoFifty", new { controller = "Home", action = "SleepFor", time = 250 });

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}