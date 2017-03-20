using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSReplicate.Startup))]
namespace CSReplicate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
