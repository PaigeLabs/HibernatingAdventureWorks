using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HibernatingCropInsurance.Startup))]
namespace HibernatingCropInsurance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
