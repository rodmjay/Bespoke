using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TechValley.Azure.TableStorage.Interfaces;
using TechValley.Azure.TableStorage.Services;

namespace TechValley.Azure.TableStorage.Factories
{
    public class TableServiceFactory : ITableServiceFactory
    {
        private readonly IOptions<TableStorageSettings> _tableSettings;
        private readonly IOptions<AzureSettings> _azureSettings;
        private readonly IServiceProvider _serviceProvider;
        private readonly string? _connectionString;

        public TableServiceFactory(IOptions<TableStorageSettings> tableSettings, IOptions<AzureSettings> azureSettings, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _tableSettings = tableSettings;
            _azureSettings = azureSettings;
            _serviceProvider = serviceProvider;
            _connectionString = configuration.GetConnectionString(tableSettings.Value.ConnectionStringName);
        }

        public TableService<T> CreateTableService<T>(string tableName) where T : class, ITableEntity, new()
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<TableService<T>>>();
            var tableService = new TableService<T>(logger, _tableSettings.Value, _azureSettings.Value, tableName);

            return tableService;
        }
    }
    
    
}
