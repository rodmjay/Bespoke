namespace AgencyPro.Shared.Models;

public class ProviderAgencyOwnerTimeEntryOutput : TimeEntryOutput
{
    [JsonIgnore] public override decimal InstantMarketerStream { get; set; }

    [JsonIgnore] public override decimal InstantRecruiterStream { get; set; }

    [JsonIgnore] public override decimal TotalMarketerStream { get; set; }

    [JsonIgnore] public override decimal TotalRecruiterStream { get; set; }

    [JsonIgnore] public override decimal InstantMarketingAgencyStream { get; set; }

    public override Guid TargetOrganizationId => ContractorOrganizationId;
    public override Guid TargetPersonId => ProviderOrganizationOwnerId;

    [JsonIgnore] public override decimal InstantRecruitingAgencyStream { get; set; }
}