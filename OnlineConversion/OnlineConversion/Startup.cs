using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineConversion.Startup))]
namespace OnlineConversion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
