namespace AgencyPro.Shared.Interfaces
{
    public interface IMarketer
    {
        Guid Id { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}