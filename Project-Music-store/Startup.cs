using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Music_store.Startup))]
namespace Project_Music_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
