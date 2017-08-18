using System.Web.Mvc;
using System.Web.Routing;
using Bank.WebApplication.Mappings;

namespace Bank.WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
