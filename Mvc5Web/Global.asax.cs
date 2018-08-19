using System.Data.Entity;
using System.Web.Routing;
using Mvc5Web.EF;

namespace Mvc5Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<DemoDbContext>(null);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
