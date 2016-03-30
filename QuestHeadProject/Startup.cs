using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestHeadProject.Startup))]
namespace QuestHeadProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
