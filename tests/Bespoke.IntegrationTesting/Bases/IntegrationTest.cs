#region Header Info

// Copyright 2024 BespokeTalent.  All rights reserved

#endregion

using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework.Legacy;
using Bespoke.Data.Interfaces;
using Bespoke.IntegrationTesting.Extensions;
using NUnit.Framework;

namespace Bespoke.IntegrationTesting.Bases;

public abstract class IntegrationTest<TFixture, TStartup> where TStartup : class
{
    public int UserId { get; set; } = 1;

    protected IntegrationTest()
    {
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
        InitializeApi();
    }

    protected IServiceProvider ServiceProvider { get; private set; }
    protected HttpClient ApiClient { get; private set; }


    private void InitializeApi()
    {
        var apiWebHostBuilder = WebHost.CreateDefaultBuilder()
            .ConfigureAppConfiguration(CustomWebHostBuilderExtensions.Configure<TFixture>)
            .UseStartup<TStartup>();

        var apiServer = new TestServer(apiWebHostBuilder);

        ServiceProvider = apiServer.Services;

        ApiClient = apiServer.CreateClient();

        ApiClient.DefaultRequestHeaders.Add("x-user-id", UserId.ToString());

    }

    protected async Task<TOutput> DoPost<TInput, TOutput>(string url, TInput input)
    {
        var content = input.SerializeToUTF8Json();
        var response = await ApiClient.PostAsync(url, content);
        Assert.That(response.IsSuccessStatusCode, Is.True);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<TOutput> DoGet<TOutput>(string url)
    {
        var response = await ApiClient.GetAsync(url);
        Assert.That(response.IsSuccessStatusCode, Is.True);

        var result = response.Content.DeserializeObject<TOutput>();

        return result;
    }

    protected async Task<TOutput> DoPut<TInput, TOutput>(string url, TInput input)
    {
        var content = input.SerializeToUTF8Json();
        var response = await ApiClient.PutAsync(url, content);
        Assert.That(response.IsSuccessStatusCode, Is.True);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<TOutput> DoDelete<TOutput>(string url)
    {
        var response = await ApiClient.DeleteAsync(url);
        Assert.That(response.IsSuccessStatusCode, Is.True);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
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