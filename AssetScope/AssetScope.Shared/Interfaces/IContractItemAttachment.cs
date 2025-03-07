namespace AssetScope.Shared.Interfaces;

public interface IContractItemAttachment
{
    int Id { get; set; }
    int ContractItemId { get; set; }
    int AttachmentTypeId { get; set; }
    string ContentType { get; set; }
    string FileName { get; set; }
    int UserId { get; set; }
    string? Description { get; set; }
    bool RestrictDownloadToFinanceOnly { get; set; }
}