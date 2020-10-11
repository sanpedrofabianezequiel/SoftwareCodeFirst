using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftwareCodeFirstUserAutentication.Startup))]
namespace SoftwareCodeFirstUserAutentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
