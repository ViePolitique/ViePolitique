using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViePolitique.WebApplication.Startup))]
namespace ViePolitique.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
