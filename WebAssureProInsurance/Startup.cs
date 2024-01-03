using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAssureProInsurance.Startup))]
namespace WebAssureProInsurance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
