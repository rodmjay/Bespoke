// logAnalyticsWorkspace.bicep

@description('The name of the Log Analytics workspace (must be globally unique).')
param workspaceName string

@description('The Azure region where the workspace will be created.')
param location string = 'East US'

@description('The SKU of the Log Analytics workspace (PerGB, Standalone, etc.).')
param sku string = 'PerGB'

@description('The retention period for logs in the Log Analytics workspace (in days).')
param retentionInDays int = 30

// Log Analytics Workspace Resource
resource logAnalyticsWorkspace 'Microsoft.OperationalInsights/workspaces@2021-06-01' = {
  name: workspaceName
  location: location
  sku: {
    name: sku
  }
  properties: {
    retentionInDays: retentionInDays
  }
}

// Output the resource ID of the Log Analytics workspace
output workspaceResourceId string = logAnalyticsWorkspace.id
