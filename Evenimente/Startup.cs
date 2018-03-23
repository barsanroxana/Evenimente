using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Evenimente.Startup))]
namespace Evenimente
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
