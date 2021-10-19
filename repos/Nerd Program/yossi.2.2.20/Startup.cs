using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yossi._2._2._20.Startup))]
namespace yossi._2._2._20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
