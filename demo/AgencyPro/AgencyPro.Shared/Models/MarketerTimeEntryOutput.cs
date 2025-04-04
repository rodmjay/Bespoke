﻿namespace AgencyPro.Shared.Models;

public class MarketerTimeEntryOutput : TimeEntryOutput
{
    [JsonIgnore] public override decimal InstantAgencyStream { get; set; }

    [JsonIgnore] public override decimal TotalAgencyStream { get; set; }

    [JsonIgnore] public override decimal InstantSystemStream { get; set; }

    [JsonIgnore] public override decimal TotalSystemStream { get; set; }

    [JsonIgnore] public override decimal InstantContractorStream { get; set; }

    [JsonIgnore] public override decimal TotalContractorStream { get; set; }

    [JsonIgnore] public override decimal InstantRecruiterStream { get; set; }

    [JsonIgnore] public override decimal TotalRecruiterStream { get; set; }

    [JsonIgnore] public override decimal InstantProjectManagerStream { get; set; }

    [JsonIgnore] public override decimal TotalProjectManagerStream { get; set; }

    [JsonIgnore] public override decimal InstantAccountManagerStream { get; set; }

    [JsonIgnore] public override decimal TotalAccountManagerStream { get; set; }

    [JsonIgnore] public override decimal TotalCustomerAmount { get; set; }

    public override Guid TargetOrganizationId => MarketingOrganizationId;
    public override Guid TargetPersonId => MarketerId;
}