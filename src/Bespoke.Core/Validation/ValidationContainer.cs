using System.Diagnostics.CodeAnalysis;
using Bespoke.Core.Validation.Interfaces;

namespace Bespoke.Core.Validation;

[ExcludeFromCodeCoverage]
public class ValidationContainer(IDictionary<string, IList<string>> validationErrors) : IValidationContainer
{
    public IDictionary<string, IList<string>> ValidationErrors { get; } = validationErrors;
    public bool IsValid { get; }
}

[ExcludeFromCodeCoverage]
public class ValidationContainer<T>(IDictionary<string, IList<string>> validationErrors, T entity)
    : IValidationContainer<T>
{
    public IDictionary<string, IList<string>> ValidationErrors { get; } = validationErrors;
    public T Entity { get; } = entity;

    public bool IsValid => ValidationErrors.Count == 0;
}