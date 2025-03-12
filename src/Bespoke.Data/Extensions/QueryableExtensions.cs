using AutoMapper;

namespace Bespoke.Data.Extensions;

public static class QueryableExtensions
{
    public static IQueryable<TDestination> ProjectTo<TDestination>(this IQueryable source, IMapper mapper)
    {
        return mapper.ProjectTo<TDestination>(source);
    }
}