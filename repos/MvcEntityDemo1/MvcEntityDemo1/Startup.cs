using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcEntityDemo1.Startup))]
namespace MvcEntityDemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
