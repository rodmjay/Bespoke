// serviceBusTopic.bicep

@description('The name of the Service Bus Topic.')
param topicName string

@description('The Service Bus Namespace ID to create the topic in.')
param serviceBusNamespaceId string

@description('Enable partitioning for the topic.')
param enablePartitioning bool = true

resource topic 'Microsoft.ServiceBus/namespaces/topics@2021-06-01' = {
  name: '${serviceBusNamespaceId}/${topicName}'
  properties: {
    requiresDuplicateDetection: false
    enablePartitioning: enablePartitioning
    enableDeadLetteringOnMessageExpiration: true
  }
}
