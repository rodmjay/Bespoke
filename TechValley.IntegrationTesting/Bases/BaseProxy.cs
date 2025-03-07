#region Header Info

// Copyright 2024 TechValleyTalent.  All rights reserved

#endregion

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TechValley.Core.Settings;
using TechValley.IntegrationTesting.Extensions;
using TechValley.Shared.Common;

namespace TechValley.IntegrationTesting.Bases;

public abstract class BaseProxy(HttpClient httpClient)
{
    protected readonly HttpClient HttpClient = httpClient;

    protected async Task<TOutput> DoPostAsync<TOutput>(string url)
    {
        var response = await HttpClient.PostAsync(url, null).ConfigureAwait(false);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<TOutput> DoPostAsync<TInput, TOutput>(string url, TInput input)
    {
        var content = input.SerializeToUTF8Json();
        var response = await HttpClient.PostAsync(url, content)
            .ConfigureAwait(false);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<ActionResult<TOutput>> DoPostActionResultAsync<TOutput>(string url)
    {
        var response = await HttpClient.PostAsync(url, null)
            .ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.DeserializeObject<TOutput>();
            return new OkObjectResult(result);
        }
        else
        {
            var result = response.Content.DeserializeObject<Result>();
            return new BadRequestObjectResult(result);
        }
    }

    protected async Task<ActionResult<TOutput>> DoPostActionResultAsync<TInput, TOutput>(string url, TInput input)
    {
        var inputContent = input!.SerializeToUTF8Json();
        var response = await HttpClient.PostAsync(url, inputContent)
            .ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.DeserializeObject<TOutput>();
            return new OkObjectResult(result);
        }
        else
        {
            var result = response.Content.DeserializeObject<Result>();
            return new BadRequestObjectResult(result);
        }
    }

    protected async Task<ActionResult<TOutput>> DoGetActionResultAsync<TOutput>(string url)
    {
        var response = await HttpClient.GetAsync(url)
            .ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.DeserializeObject<TOutput>();
            return new OkObjectResult(result);
        }
        else
        {
            var result = response.Content.DeserializeObject<Result>();
            return new BadRequestObjectResult(result);
        }
    }

    protected async Task<ActionResult<TOutput>> DoPutActionResultAsync<TInput, TOutput>(string url, TInput input)
    {
        var inputContent = input!.SerializeToUTF8Json();
        var response = await HttpClient.PutAsync(url, inputContent)
            .ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.DeserializeObject<TOutput>();
            return new OkObjectResult(result);
        }
        else
        {
            var result = response.Content.DeserializeObject<Result>();
            return new BadRequestObjectResult(result);
        }
    }

    protected async Task<ActionResult<TOutput>> DoPatchActionResultAsync<TOutput>(string url)
    {
        var response = await HttpClient.PatchAsync(url, null)
            .ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.DeserializeObject<TOutput>();
            return new OkObjectResult(result);
        }
        else
        {
            var result = response.Content.DeserializeObject<Result>();
            return new BadRequestObjectResult(result);
        }
    }

    protected async Task<TOutput> DoGetAsync<TOutput>(string url)
    {
        var response = await HttpClient.GetAsync(url).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        // Deserialize directly to the requested type
        return JsonConvert.DeserializeObject<TOutput>(json, JsonSettings.Settings);
    }


    protected IActionResult DoGet(string url)
    {
        try
        {
            var response = HttpClient.GetAsync(url).Result; // Blocking call, avoid in async scenarios
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return new OkObjectResult(content); // Return the content as a JSON response
            }

            return new StatusCodeResult((int)response.StatusCode);
        }
        catch (Exception ex)
        {
            return new StatusCodeResult(500);
        }
    }

    protected async Task<TOutput> DoPatchAsync<TOutput>(string url)
    {
        var response = await HttpClient.PatchAsync(url, null)
            .ConfigureAwait(false);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<TOutput> DoPatchAsync<TInput, TOutput>(string url, TInput input)
    {
        var content = input.SerializeToUTF8Json();
        var response = await HttpClient.PatchAsync(url, content)
            .ConfigureAwait(false);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<TOutput> DoPutAsync<TOutput>(string url)
    {
        var response = await HttpClient.PutAsync(url, null)
            .ConfigureAwait(false);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<TOutput> DoPutAsync<TInput, TOutput>(string url, TInput input)
    {
        var content = input.SerializeToUTF8Json();
        var response = await HttpClient.PutAsync(url, content)
            .ConfigureAwait(false);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<TOutput> DoDeleteAsync<TOutput>(string url)
    {
        var response = await HttpClient.DeleteAsync(url)
            .ConfigureAwait(false);

        var result = response.Content.DeserializeObject<TOutput>();
        return result;
    }

    protected async Task<ActionResult<TOutput>> DoDeleteActionResultAsync<TOutput>(string url)
    {
        var response = await HttpClient.DeleteAsync(url)
            .ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.DeserializeObject<TOutput>();
            return new OkObjectResult(result);
        }
        else
        {
            var result = response.Content.DeserializeObject<Result>();
            return new BadRequestObjectResult(result);
        }
    }

    protected async Task<ActionResult> DoActionResultGetAsync(string url)
    {
        try
        {
            var response = await HttpClient.GetAsync(url).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                // Wrapping the stream in an OkObjectResult, which isn't typical for Blazor but follows your constraint
                return new OkObjectResult(stream);
            }

            return new NotFoundResult();
        }
        catch (Exception ex)
        {
            // Handle exceptions by returning an appropriate result
            return new BadRequestObjectResult(ex.Message);
        }
    }
}