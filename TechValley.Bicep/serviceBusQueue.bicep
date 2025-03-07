// serviceBusQueue.bicep

@description('The name of the Service Bus Queue.')
param queueName string

@description('The Service Bus Namespace ID to create the queue in.')
param serviceBusNamespaceId string

@description('The maximum size of the queue in MB.')
param maxSizeInMB int = 1024

@description('Enable partitioning for the queue.')
param enablePartitioning bool = true

resource queue 'Microsoft.ServiceBus/namespaces/queues@2021-06-01' = {
  name: '${serviceBusNamespaceId}/${queueName}'
  properties: {
    lockDuration: 'PT5M'
    maxSizeInMegabytes: maxSizeInMB
    requiresDuplicateDetection: false
    enablePartitioning: enablePartitioning
    enableDeadLetteringOnMessageExpiration: true
  }
}
