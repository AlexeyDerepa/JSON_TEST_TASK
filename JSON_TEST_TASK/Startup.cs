using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSON_TEST_TASK.Startup))]
namespace JSON_TEST_TASK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
