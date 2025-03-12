namespace Bespoke.Core.Validation.Interfaces;

public interface IValidationContainer
{
    IDictionary<string, IList<string>> ValidationErrors { get; }
    bool IsValid { get; }
}

public interface IValidationContainer<out T> : IValidationContainer
{
    T Entity { get; }
}