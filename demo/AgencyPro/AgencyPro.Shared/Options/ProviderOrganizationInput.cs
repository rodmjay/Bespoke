﻿using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options;

public class ProviderOrganizationUpgradeInput
{
    public virtual bool Discoverable { get; set; }

    [Range(0, 100)] public virtual decimal AccountManagerStream { get; set; }

    [Range(0, 100)] public virtual decimal ProjectManagerStream { get; set; }

    [Range(0, 100)] public virtual decimal AgencyStream { get; set; }

    [Range(0, 999)] public virtual decimal ContractorStream { get; set; }

    [Range(0, 100)] public virtual int EstimationBasis { get; set; }

    public bool AutoApproveTimeEntries { get; set; }


    [Range(0, 60)] public virtual int PreviousDaysAllowed { get; set; }

    public virtual string ContractorInformation { get; set; }
    [Range(0, 5)] public virtual int FutureDaysAllowed { get; set; }
    public virtual string ProviderInformation { get; set; }
    public virtual string ProjectManagerInformation { get; set; }
    public virtual string AccountManagerInformation { get; set; }
    public virtual string RecruiterInformation { get; set; }
    public virtual string MarketerInformation { get; set; }
}

public class ProviderOrganizationInput : ProviderOrganizationUpgradeInput
{
    public virtual Guid DefaultProjectManagerId { get; set; }

    public virtual Guid DefaultAccountManagerId { get; set; }
    public virtual Guid DefaultContractorId { get; set; }
}