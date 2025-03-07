#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TechValley.Data;
using TechValley.Users.Contexts;

namespace TechValley.Users.Factories;

public class OperationalContextFactory : IApplicationContextFactory
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        // Used only for EF .NET Core CLI tools (update database/migrations etc.)
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            .AddJsonFile("sharedSettings.json", false, true);

        var config = builder.Build();


        var dbSettings = config.GetSection("DbSettings").Get<DbSettings>() ?? new DbSettings();

        var options = new OptionsWrapper<DbSettings>(dbSettings);

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>()
            .EnableSensitiveDataLogging()
            .UseSqlServer(config.GetConnectionString("SqlServer"));
        

        return new ApplicationContext(optionsBuilder.Options, options);
    }
}