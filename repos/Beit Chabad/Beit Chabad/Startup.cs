using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beit_Chabad.Startup))]
namespace Beit_Chabad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
