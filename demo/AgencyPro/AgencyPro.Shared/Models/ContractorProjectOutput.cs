﻿namespace AgencyPro.Shared.Models;

public class ContractorProjectOutput : ProjectOutput
{
    private Guid _targetPersonId;
    [JsonIgnore] public override decimal CustomerAverageRate { get; }

    [JsonIgnore] public override int ContractCount { get; set; }

    [JsonIgnore] public override int InvoiceCount { get; set; }


    [JsonIgnore] public override decimal WeightedContractorAverage { get; }
    public override Guid TargetOrganizationId => ProjectManagerOrganizationId;

    public override Guid TargetPersonId => _targetPersonId;

    [JsonIgnore] public override decimal WeightedAccountManagerAverage { get; }

    [JsonIgnore] public override decimal WeightedAgencyAverage { get; }
    [JsonIgnore] public override decimal WeightedMarketingAgencyAverage { get; }
    [JsonIgnore] public override decimal WeightedRecruitingAgencyAverage { get; }

    [JsonIgnore] public override decimal WeightedMarketerAverage { get; }

    [JsonIgnore] public override decimal WeightedRecruiterAverage { get; }

    [JsonIgnore] public override decimal WeightedProjectManagerAverage { get; }

    [JsonIgnore] public override decimal WeightedSystemAverage { get; }


    [JsonIgnore] public override decimal MaxMarketerStream { get; set; }

    [JsonIgnore] public override decimal MaxRecruiterStream { get; set; }

    [JsonIgnore] public override decimal MaxSystemStream { get; set; }

    [JsonIgnore] public override decimal MaxAgencyStream { get; set; }
    [JsonIgnore] public override decimal MaxRecruitingAgencyStream { get; set; }
    [JsonIgnore] public override decimal MaxMarketingAgencyStream { get; set; }

    [JsonIgnore] public override decimal MaxProjectManagerStream { get; set; }

    [JsonIgnore] public override decimal MaxAccountManagerStream { get; set; }
}