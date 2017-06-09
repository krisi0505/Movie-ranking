using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieSystem.App.Startup))]
namespace MovieSystem.App
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
