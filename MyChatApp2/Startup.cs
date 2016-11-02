using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyChatApp2.Startup))]
namespace MyChatApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
