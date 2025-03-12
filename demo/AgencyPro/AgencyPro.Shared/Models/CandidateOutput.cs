using AgencyPro.Shared.Options;

namespace AgencyPro.Shared.Models;

public abstract class CandidateOutput : CandidateInput, ICandidate, IOrganizationPersonTarget
{
    public virtual string ProviderOrganizationName { get; set; } = null!;
    public virtual string ProviderOrganizationImageUrl { get; set; } = null!;


    public bool IsExternal => RecruiterOrganizationId != ProviderOrganizationId;

    public virtual decimal RecruitingStream => RecruiterStream + RecruitingAgencyStream;
    public virtual decimal RecruitingBonus => RecruiterBonus + RecruitingAgencyBonus;

    public virtual string ProjectManagerImageUrl { get; set; } = null!;
    public virtual string ProjectManagerName { get; set; } = null!;
    public virtual string ProjectManagerOrganizationName { get; set; } = null!;
    public virtual string ProjectManagerOrganizationImageUrl { get; set; } = null!;
    public virtual string RecruiterImageUrl { get; set; } = null!;
    public virtual string RecruiterName { get; set; } = null!;
    public virtual string RecruiterPhoneNumber { get; set; } = null!;
    public virtual string RecruiterEmail { get; set; } = null!;
    public virtual string RecruiterOrganizationName { get; set; } = null!;
    public virtual string RecruiterOrganizationImageUrl { get; set; } = null!;

    public virtual Guid RecruitingOrganizationOwnerId { get; set; }
    public virtual Guid ProviderOrganizationOwnerId { get; set; }
    public virtual Guid ProviderOrganizationId { get; set; }
    public virtual Guid RecruiterId { get; set; }
    public virtual Guid RecruiterOrganizationId { get; set; }


    public CandidateStatus Status { get; set; }
    public virtual Guid Id { get; set; }

    public virtual decimal RecruiterStream { get; set; }
    public virtual decimal RecruiterBonus { get; set; }
    public virtual decimal RecruitingAgencyStream { get; set; }
    public virtual decimal RecruitingAgencyBonus { get; set; }
    public virtual RejectionReason RejectionReason { get; set; }
    public virtual string RejectionDescription { get; set; } = null!;
    public virtual Guid? ProjectManagerId { get; set; }
    public virtual Guid? ProjectManagerOrganizationId { get; set; }
    [JsonIgnore] public virtual Guid CreatedById { get; set; }
    [JsonIgnore] public virtual Guid UpdatedById { get; set; }
    public virtual DateTimeOffset Created { get; set; }
    public virtual DateTimeOffset Updated { get; set; }
    [JsonIgnore] public abstract Guid TargetOrganizationId { get; }
    [JsonIgnore] public abstract Guid TargetPersonId { get; }
}