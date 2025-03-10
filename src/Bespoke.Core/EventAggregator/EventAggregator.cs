namespace Bespoke.Core;

public class EventAggregator : IEventAggregator
{
    private readonly Dictionary<Type, List<Func<object, Task>>> _asyncHandlers = new();

    public void Subscribe<TEvent>(Func<TEvent, Task> asyncHandler)
    {
        if (!_asyncHandlers.ContainsKey(typeof(TEvent)))
            _asyncHandlers[typeof(TEvent)] = new List<Func<object, Task>>();
        _asyncHandlers[typeof(TEvent)].Add(eventObj => asyncHandler((TEvent)eventObj));
    }

    public void Publish<TEvent>(TEvent eventMessage)
    {
        if (_asyncHandlers.TryGetValue(typeof(TEvent), out var handlers))
            foreach (var handler in handlers)
                handler?.Invoke(eventMessage!); // Fire and forget; for await, see below.
    }

    public void Unsubscribe<TEvent>(Func<TEvent, Task> asyncHandler)
    {
        if (_asyncHandlers.TryGetValue(typeof(TEvent), out var handlers))
        {
            // Use LINQ to find and remove the matching handler
            var wrappedHandler =
                handlers.FirstOrDefault(h => h == (Func<object, Task>)(eventObj => asyncHandler((TEvent)eventObj)));
            if (wrappedHandler != null)
            {
                handlers.Remove(wrappedHandler);

                // Clean up the list if empty
                if (!handlers.Any()) _asyncHandlers.Remove(typeof(TEvent));
            }
        }
    }
}