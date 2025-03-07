#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Serilog;
using Bespoke.Users.Contexts;

namespace Bespoke.Users.IdentityServer.Extensions;

public static class IdentityBuilderExtensions
{

    public static void Configure(IApplicationBuilder app, IWebHostEnvironment env,
        ApplicationContext context)
    {
        context.Database.Migrate();

        JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            //app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseXXssProtection(options => options.EnabledWithBlockMode());

        app.UseSerilogRequestLogging();

        app.UseStaticFiles();
        app.UseRouting();

        app.UseIdentityServer();
        app.UseAuthorization();

        app.UseSession();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
            endpoints.MapRazorPages();
        });
    }
}