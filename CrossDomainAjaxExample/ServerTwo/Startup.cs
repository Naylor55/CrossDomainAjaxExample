using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServerTwo.Startup))]
namespace ServerTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
