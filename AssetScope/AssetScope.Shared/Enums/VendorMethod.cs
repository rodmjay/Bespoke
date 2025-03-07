using System.ComponentModel;

namespace AssetScope.Shared.Enums;

public enum VendorMethod
{
    [Description("Competition")] Competition = 0,

    [Description("Special Procurement")] SpecialProcurement = 1,

    [Description("RFP")] RFP = 2,

    [Description("RFQ")] RFQ = 3
}