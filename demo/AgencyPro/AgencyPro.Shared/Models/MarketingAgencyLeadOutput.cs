﻿namespace AgencyPro.Shared.Models;

public class MarketingAgencyLeadOutput : LeadOutput
{
    [JsonIgnore] public override Guid? AccountManagerId { get; set; }
    [JsonIgnore] public override string AccountManagerName { get; set; }
    [JsonIgnore] public override Guid? AccountManagerOrganizationId { get; set; }
    [JsonIgnore] public override string AccountManagerImageUrl { get; set; }
    [JsonIgnore] public override string AccountManagerOrganizationImageUrl { get; set; }
    [JsonIgnore] public override string AccountManagerOrganizationName { get; set; }


    public override Guid TargetOrganizationId => MarketerOrganizationId;
    public override Guid TargetPersonId => MarketingOrganizationOwnerId;

    [JsonIgnore] public override string MarketerName { get; set; }

    [JsonIgnore] public override string MarketerOrganizationName { get; set; }

    [JsonIgnore] public override string MarketerImageUrl { get; set; }
    [JsonIgnore] public override string MarketerPhoneNumber { get; set; }
    [JsonIgnore] public override string MarketerEmail { get; set; }

    [JsonIgnore] public override Guid MarketerOrganizationId { get; set; }

    [JsonIgnore] public override string MarketerOrganizationImageUrl { get; set; }

    [JsonIgnore] public override Guid MarketerId { get; set; }

    public override decimal MarketingStream { get; }

    public override decimal MarketingBonus { get; }
    public override decimal MarketingAgencyBonus { get; set; }
    public override decimal MarketingAgencyStream { get; set; }
}