using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HariharanBlog.Startup))]
namespace HariharanBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
