using System.Globalization;
using System.Reflection;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TechValley.Data.Services;

public class SeedingService
{
    private readonly Assembly _assembly;
    private readonly string _seederPath;

    // Constructor accepts assembly dynamically
    public SeedingService(Assembly assembly)
    {
        _assembly = assembly ?? throw new ArgumentNullException(nameof(assembly));
        _seederPath = $"{_assembly.GetName().Name}.Seeding";
    }

    private string GetResourceFilename(string resource)
    {
        return $"{_seederPath}.{resource}";
    }

    private CsvReader GetReader(StreamReader reader)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",",
            HeaderValidated = null,
            MissingFieldFound = null,
            UseNewObjectForNullReferenceMembers = false,
            IgnoreReferences = true
        };

        var csvReader = new CsvReader(reader, config);

        csvReader.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add("NULL");
        csvReader.Context.TypeConverterOptionsCache.GetOptions<int?>().NullValues.Add("NULL");
        csvReader.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.Add("NULL");
        csvReader.Context.TypeConverterOptionsCache.GetOptions<decimal?>().NullValues.Add("NULL");
        csvReader.Context.TypeConverterOptionsCache.GetOptions<bool>().BooleanFalseValues.Add("0");
        csvReader.Context.TypeConverterOptionsCache.GetOptions<bool>().BooleanTrueValues.Add("1");

        return csvReader;
    }

    public void Seed<TEntity>(EntityTypeBuilder<TEntity> builder, string fileName)
        where TEntity : class
    {
        var file = GetResourceFilename(fileName);
        using (var stream = _assembly.GetManifestResourceStream(file))
        {
            if (stream == null) return;
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                var csvReader = GetReader(reader);

                var records = csvReader.GetRecords<TEntity>().ToList();
                builder.HasData(records);
            }
        }
    }
}