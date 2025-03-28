﻿namespace AgencyPro.Shared.Models.Contracts;

public class AccountManagerContractOutput : ProviderContractOutput
{
    public override Guid TargetOrganizationId => AccountManagerOrganizationId;
    public override string ProjectName { get; set; }
    public override string ProjectAbbreviation { get; set; }
    public override ProjectStatus ProjectStatus { get; set; }
    public override int ProviderNumber { get; set; }
    public override decimal CustomerRate { get; set; }
    public override decimal MaxCustomerWeekly { get; set; }
    public override decimal MaxContractorWeekly { get; set; }
    public override decimal MaxProjectManagerWeekly { get; set; }
    public override decimal MaxAccountManagerWeekly { get; set; }
    public override decimal MaxAgencyWeekly { get; set; }
    public override decimal MaxSystemWeekly { get; set; }
    public override Guid MarketerOrganizationId { get; set; }
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
    public override string CustomerName { get; set; } = null!;
    public override string CustomerImageUrl { get; set; } = null!;
    public override string CustomerOrganizationName { get; set; } = null!;
    public override string CustomerOrganizationImageUrl { get; set; } = null!;
    public override Guid CustomerOrganizationId { get; set; }
    public override Guid CustomerId { get; set; }
    public override string RecruiterOrganizationName { get; set; }
    public override string RecruiterOrganizationImageUrl { get; set; }
    public override string MarketerOrganizationName { get; set; }
    public override string MarketerOrganizationImageUrl { get; set; }
    public override decimal TotalHoursLogged { get; set; }
    public override decimal TotalApprovedHours { get; set; }
    public override Guid RecruiterOrganizationId { get; set; }
    public override decimal ContractorStream { get; set; }
    public override decimal AccountManagerStream { get; set; }
    public override decimal ProjectManagerStream { get; set; }
    public override decimal SystemStream { get; set; }
    public override decimal AgencyStream { get; set; }

    public override Guid TargetPersonId => AccountManagerId;
}