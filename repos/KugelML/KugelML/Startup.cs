using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KugelML.Startup))]
namespace KugelML
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
