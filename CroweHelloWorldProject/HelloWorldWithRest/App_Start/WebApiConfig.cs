using System.Web.Http;

namespace HelloWorldWithRest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            if (config != null)
            {
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new {id = RouteParameter.Optional}
                );
            }
        }
    }
}
