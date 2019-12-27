using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestAuthentification001.Models;

[assembly: HostingStartup(typeof(TestAuthentification001.Areas.Identity.IdentityHostingStartup))]
namespace TestAuthentification001.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DefaultContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<DefaultContext>();
            });
        }
    }
}