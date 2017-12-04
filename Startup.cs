using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HF_Project_A6_1.Startup))]
namespace HF_Project_A6_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
