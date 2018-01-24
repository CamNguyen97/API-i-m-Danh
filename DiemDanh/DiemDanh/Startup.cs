using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiemDanh.Startup))]
namespace DiemDanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
