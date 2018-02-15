using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClinicaSIM.Startup))]
namespace ClinicaSIM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
