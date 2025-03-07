// appInsights.bicep
param location string = 'East US' // The location where the resource will be created
param appInsightsName string // The name of the Application Insights instance
param workspaceResourceId string // The resource ID of the Log Analytics workspace to associate with Application Insights
param sku string = 'Basic' // The SKU for the Application Insights (Basic, Standard)
param retentionInDays int = 30 // The retention period for logs (default is 30 days)

resource appInsights 'Microsoft.Insights/components@2020-02-02' = {
  name: appInsightsName
  location: location
  properties: {
    Application_Type: 'web' // You can set this to 'web', 'other', or 'endpoints'
    retentionInDays: retentionInDays
  }
  sku: {
    name: sku
  }
}

resource diagnosticSettings 'Microsoft.Insights/diagnosticSettings@2021-05-01-preview' = {
  name: '${appInsightsName}-diagnostic-settings'
  dependsOn: [
    appInsights
  ]
  properties: {
    workspaceId: workspaceResourceId // This links Application Insights with the Log Analytics workspace
    logs: [
      {
        category: 'ApplicationInsightsCore'
        enabled: true
      }
      {
        category: 'ApplicationInsightsRequests'
        enabled: true
      }
      {
        category: 'ApplicationInsightsDependencies'
        enabled: true
      }
    ]
    metrics: [
      {
        category: 'AllMetrics'
        enabled: true
      }
    ]
  }
}

output appInsightsInstrumentationKey string = appInsights.properties.InstrumentationKey
