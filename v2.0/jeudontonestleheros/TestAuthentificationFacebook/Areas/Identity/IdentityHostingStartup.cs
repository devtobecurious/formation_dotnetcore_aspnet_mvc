using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestAuthentificationFacebook.Areas.Identity.Data;
using TestAuthentificationFacebook.Models;

[assembly: HostingStartup(typeof(TestAuthentificationFacebook.Areas.Identity.IdentityHostingStartup))]
namespace TestAuthentificationFacebook.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TestAuthentificationFacebookContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TestAuthentificationFacebookContextConnection")));

                services.AddDefaultIdentity<TestAuthentificationFacebookUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TestAuthentificationFacebookContext>();
            });
        }
    }
}