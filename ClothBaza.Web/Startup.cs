using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothBaza.Web.Startup))]
namespace ClothBaza.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
