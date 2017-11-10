
using System;
using System.Collections.Generic;
using System.Text;
using Pivotal.Discovery.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace vpclub.study
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDiscoveryClient(IConfiguration);
            // Add framework services.
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            app.UseDiscoveryClient();
        }
    }
}
