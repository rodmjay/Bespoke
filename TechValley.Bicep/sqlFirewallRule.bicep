// sqlFirewallRule.bicep

@description('The ID of the SQL Server where the firewall rule will be applied.')
param sqlServerId string

@description('The name of the firewall rule.')
param firewallRuleName string

@description('The starting IP address for the firewall rule.')
param startIpAddress string

@description('The ending IP address for the firewall rule.')
param endIpAddress string

resource sqlFirewallRule 'Microsoft.Sql/servers/firewallRules@2021-02-01-preview' = {
  name: '${sqlServerId}/${firewallRuleName}'
  properties: {
    startIpAddress: startIpAddress
    endIpAddress: endIpAddress
  }
}

output firewallRuleId string = sqlFirewallRule.id
