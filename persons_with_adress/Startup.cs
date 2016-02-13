using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(persons_with_adress.Startup))]
namespace persons_with_adress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
