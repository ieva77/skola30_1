using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatDtingSite.Startup))]
namespace CatDtingSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
