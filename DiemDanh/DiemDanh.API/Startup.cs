using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DiemDanh.API.Startup))]

namespace DiemDanh.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
