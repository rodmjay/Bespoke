namespace Bespoke.Core;

public interface IEventAggregator
{
    void Subscribe<TEvent>(Func<TEvent, Task> asyncHandler);
    void Publish<TEvent>(TEvent eventMessage);
    void Unsubscribe<TEvent>(Func<TEvent, Task> asyncHandler);
}