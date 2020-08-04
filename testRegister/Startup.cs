using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testRegister.Startup))]
namespace testRegister
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
