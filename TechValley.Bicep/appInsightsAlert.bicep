// appInsightsAlert.bicep

@description('The name of the Alert rule.')
param alertName string

@description('The resource ID of the Application Insights instance.')
param appInsightsResourceId string

@description('The resource ID of the Action Group to trigger.')
param actionGroupResourceId string

@description('The threshold value for the alert.')
param threshold float

@description('The number of times the condition must be met before triggering the alert.')
param evaluationFrequency string = 'PT5M'

@description('The condition to check on the metric. Example: Total Requests.')
param metricName string = 'requests/count'

@description('The operator for the alert condition (GreaterThan, LessThan, Equal).')
param operator string = 'GreaterThan'

@description('The severity level for the alert (1 to 4).')
param severity int = 3

// Create a metric alert rule for Application Insights
resource appInsightsAlert 'Microsoft.Insights/metricAlerts@2018-03-01' = {
  name: alertName
  properties: {
    description: 'Alert for high number of requests.'
    severity: severity
    enabled: true
    criteria: {
      allOf: [
        {
          metricName: metricName
          metricNamespace: 'microsoft.insights/components'
          operator: operator
          threshold: threshold
          timeAggregation: 'Total'
        }
      ]
    }
    evaluationFrequency: evaluationFrequency
    action: {
      actionGroups: [
        {
          actionGroupId: actionGroupResourceId
        }
      ]
    }
  }
}
