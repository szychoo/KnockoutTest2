using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockoutTest2.Startup))]
namespace KnockoutTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
