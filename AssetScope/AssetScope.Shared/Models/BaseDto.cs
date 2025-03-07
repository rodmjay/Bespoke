using System.Text.Json.Serialization;
using AssetScope.Shared.Interfaces;

namespace AssetScope.Shared.Models;

/// <summary>
///     Common Base Model for all models. This is used to track the version of the application that created the model.
///     Allows for Snapshots tracking.
///     Tracks the CreatedDate, ModifiedDate, SnapshotId, IsActive, IsDeleted, DeletedDate for all models. IsActive flag
///     tracks if a record is active,
///     should be used in queries but not globally.
///     IsDeleted flag is used to track soft deletes. DeletedDate is used to track when the record was deleted.
/// </summary>
public abstract class BaseDto : IBaseModel
{
    public string AppVersion { get; set; } = AppConstants.AppVersion;
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    [JsonIgnore] public int? SnapshotId { get; set; }
    public virtual bool? IsActive { get; set; }

    [JsonIgnore] public bool IsDeleted { get; set; }

    [JsonIgnore] public DateTime? DeletedDate { get; set; }
}