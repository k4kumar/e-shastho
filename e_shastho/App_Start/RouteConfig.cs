using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace e_shastho
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "InfoDetails",
               "info_details/{id}",
               new { controller = "Info", action = "Details", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
            "Information",
            "information",
            new { controller = "Info", action = "Index", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
               "InfoCreate",
               "info_create",
               new { controller = "Info", action = "Create", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
             "Home",
             "home",
             new { controller = "Home", action = "Index", id = UrlParameter.Optional, title = UrlParameter.Optional }
            );

            routes.MapRoute(
             "AboutDeveloper",
             "about_dev",
             new { controller = "Home", action = "About", id = UrlParameter.Optional, title = UrlParameter.Optional }
            );

            routes.MapRoute(
             "PlasmaDonors",
             "plasma_donors",
             new { controller = "PlasmaDonor", action = "Index", id = UrlParameter.Optional, title = UrlParameter.Optional }
            );

            routes.MapRoute(
               "PlasmaDonorCreate",
               "plasma_donor_create",
               new { controller = "PlasmaDonor", action = "Create", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
             "TestLocationLocator",
             "test_location_locator",
             new { controller = "TestLocation", action = "MapLocator", id = UrlParameter.Optional, title = UrlParameter.Optional }
            );

            routes.MapRoute(
               "TestLocationCreate",
               "test_location_create",
               new { controller = "TestLocation", action = "Create", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
               "TestLocations",
               "testlocations",
               new { controller = "TestLocation", action = "Index", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
              "HospitalLocator",
              "hospital_locator",
              new { controller = "Hospital", action = "MapLocator", id = UrlParameter.Optional, title = UrlParameter.Optional }
          );

            routes.MapRoute(
               "HospitalCreate",
               "hospital_create",
               new { controller = "Hospital", action = "Create", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
               "Hospitals",
               "hospitals",
               new { controller = "Hospital", action = "Index", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
               "BangladeshUpdate",
               "bangladesh_update",
               new { controller = "CoronaUpdate", action = "Index", id = UrlParameter.Optional, title = UrlParameter.Optional }
           );

            routes.MapRoute(
              "WorldUpdate",
              "world_update",
              new { controller = "CoronaUpdate", action = "WorldUpdate", id = UrlParameter.Optional, title = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
