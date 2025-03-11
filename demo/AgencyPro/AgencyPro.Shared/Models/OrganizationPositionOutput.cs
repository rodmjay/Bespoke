namespace AgencyPro.Shared.Models
{
    public class OrganizationPositionOutput
    {
        public Guid OrganizationId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<LevelOutput> Levels { get; set; }
    }
}