namespace AssetScope.Shared.Enums;

public enum WorkflowConditionType
{
    None = 0, // No condition required
    RushItem = 3, // Transition applies to rush items
    FundingUpdated = 4, // Transition applies if funding has changed
    VendorNumberUpdated = 5, // Transition applies if vendor number has changed
    VendorAddressUpdated = 6, // Transition applies if vendor address has changed
    VendorRemittanceNumberFields = 7 // Transition applies if vendor remittance number fields have changed
}