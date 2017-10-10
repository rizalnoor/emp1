using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(emp1.Startup))]
namespace emp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
