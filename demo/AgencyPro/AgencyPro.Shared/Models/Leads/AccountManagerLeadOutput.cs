﻿namespace AgencyPro.Shared.Models.Leads;

public class AccountManagerLeadOutput : LeadOutput
{
    public override Guid TargetOrganizationId => ProviderOrganizationId;
    public override Guid TargetPersonId => AccountManagerId.Value;

    [JsonIgnore] public override decimal MarketerStream { get; set; }
    [JsonIgnore] public override decimal MarketerBonus { get; set; }
    [JsonIgnore] public override decimal MarketingAgencyBonus { get; set; }
    [JsonIgnore] public override decimal MarketingAgencyStream { get; set; }
}