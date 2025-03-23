namespace Bespoke.IntegrationTesting.Extensions;

public static class EnumerableExtensions
{
    public static async IAsyncEnumerable<T> ToAsyncEnumerable<T>(this IEnumerable<T> source)
    {
        foreach (var item in source)
        {
            yield return item;
            await Task.Yield(); // Ensure it's asynchronous
        }
    }
}