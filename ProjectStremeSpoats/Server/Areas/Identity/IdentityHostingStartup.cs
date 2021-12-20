using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectStremeSpoats.Server.Data;
using ProjectStremeSpoats.Server.Models;

[assembly: HostingStartup(typeof(ProjectStremeSpoats.Server.Areas.Identity.IdentityHostingStartup))]
namespace ProjectStremeSpoats.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}