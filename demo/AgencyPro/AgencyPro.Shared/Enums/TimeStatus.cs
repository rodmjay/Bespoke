namespace AgencyPro.Shared.Enums;

public enum TimeStatus
{
    None = 0,
    Logged = 1,
    Approved = 2,
    InvoiceSent = 4,
    Rejected = 8,
    PendingPayout = 16,

    Uncollectible = 32,
    Voided = 33,
    Dispersed = 64
}