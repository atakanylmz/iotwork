using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iotWork.Startup))]
namespace iotWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
//ConfigureAuth(app);
        }
    }
}
