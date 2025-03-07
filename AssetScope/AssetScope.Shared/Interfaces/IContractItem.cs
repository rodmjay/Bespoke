using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface IContractItem
{
    int Id { get; set; }
    int UserId { get; set; }
    string Email { get; set; }
    string? Position { get; set; }
    string? PhoneNumber { get; set; }
    ApprovalStatus ApprovalStatus { get; set; }
    string? ProgramAreaId { get; set; }
    bool ItemRush { get; set; }
    decimal? RequestedAmount { get; set; }
    DateTime? ItemRushApproved { get; set; }
    ItemRushType? ItemRushType { get; set; }
    string? ItemRushDescription { get; set; }
    string? DescriptionOfWork { get; set; }
    DateTime? ContractStartDate { get; set; }
    DateTime? ContractEndDate { get; set; }
    string? StatutoryAuthorityCode { get; set; }
    ContractItemType ItemType { get; set; }
    bool IsLegacy { get; set; }
    ContractState State { get; set; }
    string? ClosingReason { get; set; }
    bool ReturnedToDraft { get; set; }
    string? EdsNumber { get; set; }
    int? ManagerId { get; set; }
}