using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using News.Data;

namespace News
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			// Start Global data 
			Global.Init();

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
