// sqlDatabase.bicep

@description('The ID of the SQL Server where the database will be created.')
param sqlServerId string

@description('The name of the SQL Database to be created.')
param sqlDatabaseName string

@description('The edition of the SQL Database.')
param databaseEdition string = 'Basic' // Options: Basic, Standard, Premium

@description('The maximum storage size of the SQL Database in GB.')
param maxSizeGb int = 5

@description('The backup retention period in days for the SQL Database.')
param backupRetention int = 7

resource sqlDatabase 'Microsoft.Sql/servers/databases@2021-02-01-preview' = {
  name: '${sqlServerId}/${sqlDatabaseName}'
  properties: {
    edition: databaseEdition
    maxSizeBytes: maxSizeGb * 1024 * 1024 * 1024 // Convert GB to bytes
  }
}

output sqlDatabaseId string = sqlDatabase.id
