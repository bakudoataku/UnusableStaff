using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WypozyczalniaSamochodow.Startup))]
namespace WypozyczalniaSamochodow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
