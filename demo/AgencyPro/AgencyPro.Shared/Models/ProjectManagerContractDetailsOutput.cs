namespace AgencyPro.Shared.Models;

public class ProjectManagerContractDetailsOutput : ProjectManagerContractOutput
{
    public ICollection<ProjectManagerTimeEntryOutput> TimeEntries { get; set; }
    public ICollection<ProjectManagerStoryOutput> Stories { get; set; }
    public ICollection<CommentOutput> Comments { get; set; }
}