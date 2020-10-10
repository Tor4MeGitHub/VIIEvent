using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRConnection.Startup1))]

namespace SignalRConnection
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
