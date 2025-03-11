namespace AgencyPro.Shared.Options
{
    public class ProjectInput
    {
        private string _abbreviation;

        public virtual Guid ProjectManagerId { get; set; }

        public virtual Guid ProjectManagerOrganizationId { get; set; }

        public virtual int AccountNumber { get; set; }
        public bool AutoApproveTimeEntries { get; set; }

        public string Name { get; set; }

        public string Abbreviation
        {
            get => _abbreviation.ToUpper();
            set => _abbreviation = value;
        }
    }
}