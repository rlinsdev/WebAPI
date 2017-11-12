using System.Web.Http;

namespace WebApi.Configuration
{
	public static class WebAPIConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			var formatters = GlobalConfiguration.Configuration.Formatters;
			formatters.Remove(formatters.XmlFormatter);
		}
	}
}