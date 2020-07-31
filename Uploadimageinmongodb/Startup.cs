using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uploadimageinmongodb.Startup))]
namespace Uploadimageinmongodb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
