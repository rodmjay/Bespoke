using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options;

public class StoryInput
{
    [Required] public virtual string Title { get; set; }

    public virtual string Description { get; set; }

    public virtual int? StoryPoints { get; set; }

    public virtual Guid ProjectId { get; set; }

    public virtual DateTimeOffset? AssignedDateTime { get; set; }
    public virtual DateTimeOffset? ProjectManagerAcceptanceDate { get; set; }
    public virtual DateTimeOffset? CustomerAcceptanceDate { get; set; }
}