namespace AgencyPro.Shared.Interfaces;

public interface IProjectInvoice : IInvoice
{
    Guid ProjectId { get; set; }

    DateTimeOffset Created { get; set; }
    DateTimeOffset Updated { get; set; }
    string RefNo { get; set; }
}