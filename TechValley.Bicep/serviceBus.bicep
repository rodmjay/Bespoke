// serviceBusNamespace.bicep

@description('The name of the Service Bus Namespace.')
param serviceBusNamespaceName string

@description('The location for the Service Bus Namespace.')
param location string = resourceGroup().location

@description('SKU of the Service Bus namespace (Basic, Standard, Premium).')
param sku string = 'Standard'

resource serviceBusNamespace 'Microsoft.ServiceBus/namespaces@2021-06-01' = {
  name: serviceBusNamespaceName
  location: location
  sku: {
    name: sku
    tier: sku
  }
  properties: {
    zoneRedundant: false
  }
}

output serviceBusNamespaceId string = serviceBusNamespace.id
