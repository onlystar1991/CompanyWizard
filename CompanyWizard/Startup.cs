using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompanyWizard.Startup))]
namespace CompanyWizard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
