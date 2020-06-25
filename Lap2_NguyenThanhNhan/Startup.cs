using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lap2_NguyenThanhNhan.Startup))]
namespace Lap2_NguyenThanhNhan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
