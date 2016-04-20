using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application.UI.Startup))]
namespace Application.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
