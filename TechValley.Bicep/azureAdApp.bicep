// azureADApp.bicep

@description('The name of the Azure AD Application.')
param applicationName string

@description('The homepage URL of the application.')
param homePage string

@description('The redirect URI for the application (optional for multi-tenant apps).')
param redirectUri string = ''

@description('The identifier URI for the application (API identifier).')
param identifierUri string

@description('The type of the application (Web, Native, etc.).')
param appType string = 'Web'

@description('Enable multi-tenant support for the app.')
param isMultiTenant bool = true

resource azureAdApp 'Microsoft.Graph/application@1.0' = {
  name: applicationName
  properties: {
    displayName: applicationName
    isPublicClient: appType == 'Native' ? true : false
    signInAudience: isMultiTenant ? 'AzureADMultipleOrgs' : 'AzureADMyOrg'
    web: {
      redirectUris: [redirectUri]
    }
    api: {
      requestedAccessTokenVersion: 2
      identifierUris: [identifierUri]
    }
  }
}

output applicationId string = azureAdApp.id
output applicationObjectId string = azureAdApp.properties.objectId
