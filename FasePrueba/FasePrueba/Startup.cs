using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FasePrueba.Startup))]
namespace FasePrueba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
