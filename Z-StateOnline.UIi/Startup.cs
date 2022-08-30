using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Z_StateOnline.UIi.Startup))]
namespace Z_StateOnline.UIi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
