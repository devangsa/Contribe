using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContribeBookStore.Startup))]
namespace ContribeBookStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          //  ConfigureAuth(app);
        }
    }
}
