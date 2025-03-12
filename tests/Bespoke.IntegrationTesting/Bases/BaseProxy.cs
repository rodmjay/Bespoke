using System.Net;
using System.Security.Authentication;
using System.Text;
using Bespoke.Core.Settings;
using Bespoke.IntegrationTesting.Extensions;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Bespoke.IntegrationTesting.Bases;

public abstract class BaseProxy
{
    protected readonly HttpClient HttpClient;

    protected BaseProxy(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    private void ValidateResponse(HttpResponseMessage response)
    {
        if (response.StatusCode == HttpStatusCode.Forbidden)
            throw new UnauthorizedAccessException();

        if (response.StatusCode == HttpStatusCode.Unauthorized)
            throw new AuthenticationException();
    }

    private async Task<T> DeserializeContentAsync<T>(HttpContent content)
    {
        var json = await content.ReadAsStringAsync().ConfigureAwait(false);
        return JsonConvert.DeserializeObject<T>(json, JsonSettings.Settings)!;
    }

    protected async Task<TOutput> DoPostAsync<TOutput>(string url)
    {
        var response = await HttpClient.PostAsync(url, null).ConfigureAwait(false);
        ValidateResponse(response);
        return await DeserializeContentAsync<TOutput>(response.Content);
    }

    protected async Task<IAsyncEnumerable<T>> DoPostAsyncEnumerable<TInput, T>(string url, TInput input)
    {
        var content = input!.SerializeToUTF8Json();

        var response = await HttpClient.PostAsync(url, content).ConfigureAwait(false);

        ValidateResponse(response);

        var items = await DeserializeContentAsync<List<T>>(response.Content);

        return items.ToAsyncEnumerable();
    }


    protected async Task<TOutput> DoPostAsync<TInput, TOutput>(string url, TInput input)
    {
        var content = input.SerializeToUTF8Json();
        var response = await HttpClient.PostAsync(url, content).ConfigureAwait(false);
        ValidateResponse(response);
        return await DeserializeContentAsync<TOutput>(response.Content);
    }

    protected async Task<ActionResult<TOutput>> DoPostActionResultAsync<TInput, TOutput>(string url, TInput input)
    {
        var content = input.SerializeToUTF8Json();
        var response = await HttpClient.PostAsync(url, content).ConfigureAwait(false);
        ValidateResponse(response);

        if (response.IsSuccessStatusCode)
        {
            var result = await DeserializeContentAsync<TOutput>(response.Content);
            return new OkObjectResult(result);
        }

        var error = await DeserializeContentAsync<Result>(response.Content);
        return new BadRequestObjectResult(error);
    }

    protected async Task<ActionResult<TOutput>> DoGetActionResultAsync<TOutput>(string url)
    {
        var response = await HttpClient.GetAsync(url).ConfigureAwait(false);
        ValidateResponse(response);

        if (response.IsSuccessStatusCode)
        {
            var result = await DeserializeContentAsync<TOutput>(response.Content);
            return new OkObjectResult(result);
        }

        var error = await DeserializeContentAsync<Result>(response.Content);
        return new BadRequestObjectResult(error);
    }

    protected async Task<ActionResult<TOutput>> DoPutActionResultAsync<TInput, TOutput>(string url, TInput input)
    {
        var content = input!.SerializeToUTF8Json();
        var response = await HttpClient.PutAsync(url, content).ConfigureAwait(false);
        ValidateResponse(response);

        if (response.IsSuccessStatusCode)
        {
            var result = await DeserializeContentAsync<TOutput>(response.Content);
            return new OkObjectResult(result);
        }

        var error = await DeserializeContentAsync<Result>(response.Content);
        return new BadRequestObjectResult(error);
    }

    protected async Task<ActionResult<TOutput>> DoPatchActionResultWithBodyAsync<TOutput>(string url, object payload)
    {
        // Serialize the payload to JSON and create StringContent with proper encoding and media type.
        var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

        // Execute the PATCH request with the provided content.
        var response = await HttpClient.PatchAsync(url, content).ConfigureAwait(false);
        ValidateResponse(response);

        if (response.IsSuccessStatusCode)
        {
            var result = await DeserializeContentAsync<TOutput>(response.Content);
            return new OkObjectResult(result);
        }

        var error = await DeserializeContentAsync<Result>(response.Content);
        return new BadRequestObjectResult(error);
    }

    protected async Task<ActionResult<TOutput>> DoPatchActionResultAsync<TOutput>(string url)
    {
        var response = await HttpClient.PatchAsync(url, null).ConfigureAwait(false);
        ValidateResponse(response);

        if (response.IsSuccessStatusCode)
        {
            var result = await DeserializeContentAsync<TOutput>(response.Content);
            return new OkObjectResult(result);
        }

        var error = await DeserializeContentAsync<Result>(response.Content);
        return new BadRequestObjectResult(error);
    }

    protected async Task<TOutput> DoGetAsync<TOutput>(string url)
    {
        var response = await HttpClient.GetAsync(url).ConfigureAwait(false);
        ValidateResponse(response);
        response.EnsureSuccessStatusCode();
        return await DeserializeContentAsync<TOutput>(response.Content);
    }

    protected T DoGet<T>(string url)
    {
        // Send GET request
        var response = HttpClient.GetAsync(url).Result; // Blocking call
        ValidateResponse(response);

        // Process response
        if (response.IsSuccessStatusCode)
        {
            // Deserialize content into the specified generic type
            var result = DeserializeContentAsync<T>(response.Content).Result;

            return result;
        }

        throw new Exception();
    }

    protected IActionResult DoGet(string url)
    {
        try
        {
            var response = HttpClient.GetAsync(url).Result; // Blocking call
            ValidateResponse(response);

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return new OkObjectResult(content);
            }

            return new StatusCodeResult((int)response.StatusCode);
        }
        catch
        {
            return new StatusCodeResult(500);
        }
    }

    protected async Task<TOutput> DoDeleteAsync<TOutput>(string url)
    {
        var response = await HttpClient.DeleteAsync(url).ConfigureAwait(false);
        ValidateResponse(response);
        return await DeserializeContentAsync<TOutput>(response.Content);
    }

    protected async Task<ActionResult<TOutput>> DoDeleteActionResultAsync<TOutput>(string url)
    {
        var response = await HttpClient.DeleteAsync(url).ConfigureAwait(false);
        ValidateResponse(response);

        if (response.IsSuccessStatusCode)
        {
            var result = await DeserializeContentAsync<TOutput>(response.Content);
            return new OkObjectResult(result);
        }

        var error = await DeserializeContentAsync<Result>(response.Content);
        return new BadRequestObjectResult(error);
    }

    protected async Task<ActionResult> DoActionResultGetAsync(string url)
    {
        try
        {
            var response = await HttpClient.GetAsync(url).ConfigureAwait(false);
            ValidateResponse(response);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                return new OkObjectResult(stream);
            }

            return new NotFoundResult();
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }
}