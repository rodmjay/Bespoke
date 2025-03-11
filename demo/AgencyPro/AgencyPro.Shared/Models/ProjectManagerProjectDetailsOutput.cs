namespace AgencyPro.Shared.Models
{
    public class ProjectManagerProjectDetailsOutput : ProjectManagerProjectOutput
    {
        public ICollection<ProjectManagerContractOutput> Contracts { get; set; }
        public ICollection<ProjectManagerStoryOutput> Stories { get; set; }
        public ICollection<ProjectManagerTimeEntryOutput> PendingTimeEntries { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ProjectStatus> StatusTransitions { get; set; }
        public IDictionary<TimeStatus, int> TimeEntryStatus { get; set; }
        public IDictionary<StoryStatus, int> StoryStatus { get; set; }
        public IDictionary<ContractStatus, int> ContractStatus { get; set; }

    }
}