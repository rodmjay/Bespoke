using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models;

public class AgencyOwnerMarketingContractOutput : MarketingContractOutput
{
    public override Guid TargetOrganizationId => MarketerOrganizationId;
    public override decimal MarketingAgencyStream { get; set; }
    public override decimal MaxMarketerWeekly { get; set; }
    public override decimal MaxMarketingAgencyWeekly { get; set; }

    public override int MarketingNumber { get; set; }
    public override Guid MarketerId { get; set; }
    public override Guid MarketerOrganizationId { get; set; }
    public override string CustomerName { get; set; } = null!;
    public override string CustomerEmail { get; set; } = null!;
    public override string CustomerPhoneNumber { get; set; } = null!;
    public override string CustomerImageUrl { get; set; } = null!;
    public override string CustomerOrganizationName { get; set; } = null!;
    public override string CustomerOrganizationImageUrl { get; set; } = null!;
    public override Guid CustomerOrganizationId { get; set; }
    public override Guid CustomerId { get; set; }
    public override string MarketerName { get; set; } = null!;
    public override string MarketerEmail { get; set; } = null!;
    public override string MarketerPhoneNumber { get; set; } = null!;
    public override string MarketerImageUrl { get; set; } = null!;
    public override string MarketerOrganizationName { get; set; } = null!;
    public override string MarketerOrganizationImageUrl { get; set; } = null!;
    public override decimal TotalHoursLogged { get; set; }
    public override decimal TotalApprovedHours { get; set; }
    public override decimal MarketerStream { get; set; }

    public override Guid TargetPersonId => Guid.Empty;
}