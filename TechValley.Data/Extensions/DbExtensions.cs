#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace TechValley.Data.Extensions;

[ExcludeFromCodeCoverage]
public static class DbExtensions
{
    public static Expression<Func<T, bool>> BuildLikeExpression<T>(
        string[] keywords,
        params Expression<Func<T, string>>[] properties)
    {
        Expression expression = null!;
        var parameterExpression = Expression.Parameter(typeof(T), "x");

        foreach (var propertyExpression in properties)
        {
            var body = (MemberExpression)propertyExpression.Body;
            var name = body.Member.Name;
            var property = Expression.Property(parameterExpression, name);

            foreach (var keyword in keywords)
            {
                var normalized = $"%{keyword}%";
                var constant = Expression.Constant(normalized);
                var methodCallExpression = Expression.Call(
                    typeof(DbFunctionsExtensions),
                    nameof(DbFunctionsExtensions.Like),
                    null,
                    Expression.Constant(EF.Functions),
                    property,
                    constant);

                expression = expression == null
                    ? methodCallExpression
                    : Expression.OrElse(expression, methodCallExpression);
            }
        }

        return Expression.Lambda<Func<T, bool>>(expression, parameterExpression);
    }

    public static Expression<Func<T, bool>> BuildLikeExpression<T>(
        string[] keywords,
        Expression<Func<T, string>> action,
        bool caseInsensitive = false)
    {
        var body = (MemberExpression)action.Body;
        var name = body.Member.Name;

        Expression expression = null!;
        var parameterExpression = Expression.Parameter(typeof(T), "x");
        var property = Expression.Property(parameterExpression, name);

        foreach (var keyword in keywords)
        {
            var normalized = $"%{keyword}%";
            var constant = Expression.Constant(normalized);

            string methodName = caseInsensitive ? "ILike" : "Like";
            var methodCallExpression = Expression.Call(
                typeof(DbFunctionsExtensions),
                methodName,
                null,
                Expression.Constant(EF.Functions),
                property,
                constant);

            expression = expression == null
                ? methodCallExpression
                : Expression.OrElse(expression, methodCallExpression);
        }

        return Expression.Lambda<Func<T, bool>>(expression, parameterExpression);
    }

}