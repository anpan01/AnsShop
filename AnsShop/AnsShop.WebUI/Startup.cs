using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnsShop.WebUI.Startup))]
namespace AnsShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
