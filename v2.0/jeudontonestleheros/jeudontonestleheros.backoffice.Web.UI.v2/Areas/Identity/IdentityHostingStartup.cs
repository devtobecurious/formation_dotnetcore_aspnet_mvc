using System;
using jeudontonestleheros.backoffice.Web.UI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(jeudontonestleheros.backoffice.Web.UI.v2.Areas.Identity.IdentityHostingStartup))]
namespace jeudontonestleheros.backoffice.Web.UI.v2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<jeudontonestleherosbackofficeWebUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("jeudontonestleherosbackofficeWebUIContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<jeudontonestleherosbackofficeWebUIContext>();
            });
        }
    }
}