using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmexBtcSolution.Startup))]
namespace AmexBtcSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
