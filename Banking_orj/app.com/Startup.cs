using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(app.com.Startup))]
namespace app.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
