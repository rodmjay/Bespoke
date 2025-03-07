#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Globalization;
using HandlebarsDotNet;
using TechValley.Core.Builders;

namespace TechValley.Handlebars;

public static class AppBuilderExtensions
{
    public static AppBuilder RegisterHandlebarsExtensions(this AppBuilder builder)
    {
        HandlebarsDotNet.Handlebars.RegisterHelper("formatDate", (writer, context, parameters) =>
        {
            if (parameters[0] is DateTime dateTime)
                writer.WriteSafeString(dateTime.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            else if (DateTime.TryParse(parameters[0]?.ToString(), out var parsedDate))
                writer.WriteSafeString(parsedDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            else
                writer.WriteSafeString(parameters[0]?.ToString());
        });

        HandlebarsDotNet.Handlebars.RegisterHelper("eq", (output, options, context, arguments) =>
        {
            if (arguments.Length != 2) throw new HandlebarsException("eq helper must have exactly two arguments");

            var left = arguments[0];
            var right = arguments[1];

            var isEqual = left?.ToString() == right?.ToString();
            if (isEqual)
                options.Template(output, context); // Render the main block if true
            else
                options.Inverse(output, context); // Render the inverse block if false
        });

        return builder;
    }

}