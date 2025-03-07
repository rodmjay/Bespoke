// acr.bicep
param location string = 'East US'
param registryName string // The name of the container registry
param sku string = 'Basic' // The SKU for the registry (Basic, Standard, Premium)

resource acr 'Microsoft.ContainerRegistry/registries@2022-02-01' = {
  name: registryName
  location: location
  sku: {
    name: sku // 'Basic', 'Standard', or 'Premium'
  }
  properties: {
    adminUserEnabled: true // Enable admin user for ACR access
  }
}

output acrLoginServer string = acr.properties.loginServer
