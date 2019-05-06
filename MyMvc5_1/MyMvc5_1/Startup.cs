using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMvc5_1.Startup))]
namespace MyMvc5_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
