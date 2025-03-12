using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models;

public class ContractorContractOutput : ProviderContractOutput
{
    public override Guid TargetOrganizationId => ContractorOrganizationId;
    [JsonIgnore] public override decimal AccountManagerStream { get; set; }

    [JsonIgnore] public override decimal ProjectManagerStream { get; set; }

    [JsonIgnore] public override decimal SystemStream { get; set; }

    [JsonIgnore] public override decimal AgencyStream { get; set; }

    public override string ProjectName { get; set; } = null!;
    public override string ProjectAbbreviation { get; set; } = null!;
    public override ProjectStatus ProjectStatus { get; set; }

    public override int ProviderNumber { get; set; }

    [JsonIgnore] public override decimal CustomerRate { get; set; }

    [JsonIgnore] public override Guid RecruiterOrganizationId { get; set; }
    public override decimal ContractorStream { get; set; }

    [JsonIgnore] public override Guid MarketerOrganizationId { get; set; }
    public override string ProjectManagerName { get; set; } = null!;
    public override string ProjectManagerOrganizationName { get; set; } = null!;
    public override Guid ProjectManagerId { get; set; }
    public override Guid ProjectManagerOrganizationId { get; set; }
    public override string ProjectManagerImageUrl { get; set; } = null!;
    public override string ProjectManagerOrganizationImageUrl { get; set; } = null!;
    public override string AccountManagerName { get; set; } = null!;
    public override Guid AccountManagerId { get; set; }
    public override Guid AccountManagerOrganizationId { get; set; }
    public override string AccountManagerOrganizationName { get; set; } = null!;
    public override string AccountManagerImageUrl { get; set; } = null!;
    public override string AccountManagerOrganizationImageUrl { get; set; } = null!;
    public override string ContractorName { get; set; } = null!;
    public override string ContractorOrganizationName { get; set; } = null!;
    public override string ContractorImageUrl { get; set; } = null!;
    public override string ContractorOrganizationImageUrl { get; set; } = null!;


    [JsonIgnore] public override decimal MaxCustomerWeekly { get; set; }
    public override decimal MaxContractorWeekly { get; set; }

    [JsonIgnore] public override decimal MaxProjectManagerWeekly { get; set; }

    [JsonIgnore] public override decimal MaxAccountManagerWeekly { get; set; }

    [JsonIgnore] public override decimal MaxAgencyWeekly { get; set; }

    [JsonIgnore] public override decimal MaxSystemWeekly { get; set; }

    [JsonIgnore] public override string CustomerName { get; set; } = null!;
    [JsonIgnore] public override string CustomerImageUrl { get; set; } = null!;
    [JsonIgnore] public override Guid CustomerOrganizationId { get; set; }
    [JsonIgnore] public override Guid CustomerId { get; set; }
    [JsonIgnore] public override string CustomerOrganizationImageUrl { get; set; } = null!;
    [JsonIgnore] public override string CustomerOrganizationName { get; set; } = null!;


    [JsonIgnore] public override string MarketerOrganizationImageUrl { get; set; } = null!;
    public override decimal TotalHoursLogged { get; set; }
    public override decimal TotalApprovedHours { get; set; }
    [JsonIgnore] public override string MarketerOrganizationName { get; set; } = null!;

    [JsonIgnore] public override string RecruiterOrganizationImageUrl { get; set; } = null!;

    [JsonIgnore] public override string RecruiterOrganizationName { get; set; } = null!;

    public override Guid TargetPersonId => ContractorId;
}