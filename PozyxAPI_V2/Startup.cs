using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using PozyxAPI_V2.Controllers;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(PozyxAPI_V2.Startup))]

namespace PozyxAPI_V2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            //app.MapSignalR<MyEndPoint>("/hello");
            //app.MapSignalR("http://172.20.10.3:8080/hello", new HubConfiguration());
            ConfigureAuth(app);
        }
    }
}

