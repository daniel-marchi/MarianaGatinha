using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ListaTelefonica.Startup))]
namespace ListaTelefonica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
