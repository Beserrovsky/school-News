using News.Controllers;
using News.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace News
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			

			routes.MapRoute(
				name: "Noticias",
				url: "Noticias/{id}",
				defaults: new { controller = "Noticias", action = "Index" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
