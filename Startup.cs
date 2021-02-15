using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(brendanLowe_MIS4200.Startup))]
namespace brendanLowe_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
