using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stock.Startup))]
namespace Stock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
