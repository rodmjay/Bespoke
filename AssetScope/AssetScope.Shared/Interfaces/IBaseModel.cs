namespace AssetScope.Shared.Interfaces;

public interface IBaseModel
{
    string AppVersion { get; set; }
    DateTime CreatedDate { get; set; }
    DateTime ModifiedDate { get; set; }
    int? SnapshotId { get; set; }
    bool? IsActive { get; set; }
    bool IsDeleted { get; set; }
    DateTime? DeletedDate { get; set; }
}