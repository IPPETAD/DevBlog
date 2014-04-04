using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevBlog.Startup))]
namespace DevBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
