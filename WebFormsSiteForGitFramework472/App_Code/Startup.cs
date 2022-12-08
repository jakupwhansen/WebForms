using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsSiteForGitFramework472.Startup))]
namespace WebFormsSiteForGitFramework472
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
