namespace AgencyPro.Shared.Interfaces
{
    public interface IRecruiter
    {
        Guid Id { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}