using Bespoke.Core.Extensions;
using Bespoke.Data.Interfaces;
using Bespoke.IntegrationTesting.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Bespoke.IntegrationTesting.Bases;

public abstract class IntegrationTest<TFixture, TStartup> where TStartup : class
{
    protected IntegrationTest()
    {
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
        InitializeApi();
    }

    public int UserId { get; set; } = 1;
    public int LoggedInUser { get; set; } = 1;

    protected IServiceProvider ServiceProvider { get; private set; }
    protected HttpClient ApiClient { get; private set; }


    private void InitializeApi()
    {
        var hostBuilder = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(CustomWebHostBuilderExtensions.Configure<TFixture>)
            .UseSerilog(HostBuilderExtensions.ConfigureLogging)
            .ConfigureWebHost(webBuilder =>
            {
                // Instruct the host to use TestServer instead of Kestrel
                webBuilder.UseTestServer();
                // Override any URL settings to avoid binding conflicts.
                webBuilder.UseSetting("server.urls", "http://localhost");
                webBuilder.UseStartup<TStartup>();
            });

        // Start the host
        var host = hostBuilder.Start();
        ServiceProvider = host.Services;

        // Retrieve the TestServer instance
        var testServer = host.GetTestServer();

        // Configure HttpClient with your custom UserIdHandler
        var handler = new UserIdHandler(() => LoggedInUser)
        {
            InnerHandler = testServer.CreateHandler()
        };

        ApiClient = new HttpClient(handler)
        {
            BaseAddress = testServer.BaseAddress
        };
    }

    protected async Task ResetDatabase()
    {
        using var scope = ServiceProvider.CreateScope();
        var scopedProvider = scope.ServiceProvider;
        var context = scopedProvider.GetRequiredService<IDataContextAsync>();

        await context.Facade.EnsureDeletedAsync();
        await context.Facade.MigrateAsync();
    }

    protected async Task DeleteDatabase()
    {
        using var scope = ServiceProvider.CreateScope();
        var scopedProvider = scope.ServiceProvider;
        var context = scopedProvider.GetRequiredService<IDataContextAsync>();

        await context.Facade.EnsureDeletedAsync();
    }
}