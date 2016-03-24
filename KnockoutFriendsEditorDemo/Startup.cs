using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockoutFriendsEditorDemo.Startup))]
namespace KnockoutFriendsEditorDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
