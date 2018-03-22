using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Swagger.WebMvc.Startup))]
namespace Swagger.WebMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
