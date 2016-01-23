using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReservationsApp.Startup))]
namespace ReservationsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
