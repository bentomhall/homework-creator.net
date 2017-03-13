using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeworkCreator.Startup))]
namespace HomeworkCreator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
