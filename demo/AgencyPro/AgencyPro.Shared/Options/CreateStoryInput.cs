using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options;

public class CreateStoryInput
{
    [Required] public virtual string Title { get; set; }

    public virtual string Description { get; set; }

    public virtual int StoryPoints { get; set; }

    public virtual Guid ProjectId { get; set; }

    public Guid? ContractorId { get; set; }

    public Guid? TemplateId { get; set; }
}