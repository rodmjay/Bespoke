namespace AssetScope.Shared.Interfaces;

public interface IAttachmentType
{
    int AttachmentTypeId { get; set; }
    string TypeName { get; set; }
    string Description { get; set; }
}