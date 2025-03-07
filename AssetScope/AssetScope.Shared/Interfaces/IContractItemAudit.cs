using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface IContractItemAudit
{
    int AuditId { get; set; }
    int ContractItemId { get; set; }
    AuditType AuditType { get; set; }
    string Value { get; set; }
    int CreatedBy { get; set; }
}