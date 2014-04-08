using Microsoft.Owin;
using Owin;
using SikhUnit.Site;

[assembly: OwinStartup(typeof(Startup))]
namespace SikhUnit.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}