using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThemisCodingChallenge.Startup))]
namespace ThemisCodingChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
