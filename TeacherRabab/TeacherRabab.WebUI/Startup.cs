using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeacherRabab.WebUI.Startup))]
namespace TeacherRabab.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
