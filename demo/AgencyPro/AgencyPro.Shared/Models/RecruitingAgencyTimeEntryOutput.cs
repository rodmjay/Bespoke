﻿namespace AgencyPro.Shared.Models;

public class RecruitingAgencyTimeEntryOutput : TimeEntryOutput
{
    [JsonIgnore] public override decimal InstantAgencyStream { get; set; }

    [JsonIgnore] public override decimal TotalAgencyStream { get; set; }

    [JsonIgnore] public override decimal InstantSystemStream { get; set; }

    [JsonIgnore] public override decimal TotalSystemStream { get; set; }

    [JsonIgnore] public override decimal InstantContractorStream { get; set; }

    [JsonIgnore] public override decimal TotalContractorStream { get; set; }

    [JsonIgnore] public override decimal InstantMarketerStream { get; set; }

    [JsonIgnore] public override decimal TotalMarketerStream { get; set; }

    [JsonIgnore] public override decimal InstantProjectManagerStream { get; set; }

    [JsonIgnore] public override decimal TotalProjectManagerStream { get; set; }

    [JsonIgnore] public override decimal InstantAccountManagerStream { get; set; }

    [JsonIgnore] public override decimal TotalAccountManagerStream { get; set; }

    [JsonIgnore] public override decimal TotalCustomerAmount { get; set; }

    public override Guid TargetOrganizationId => RecruitingOrganizationId;
    public override Guid TargetPersonId => RecruitingOrganizationOwnerId;
}