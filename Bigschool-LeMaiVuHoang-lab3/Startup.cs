using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschool_LeMaiVuHoang_lab3.Startup))]
namespace Bigschool_LeMaiVuHoang_lab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
