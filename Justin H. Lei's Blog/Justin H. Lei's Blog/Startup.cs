using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Justin_H.Lei_s_Blog.Startup))]
namespace Justin_H.Lei_s_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
