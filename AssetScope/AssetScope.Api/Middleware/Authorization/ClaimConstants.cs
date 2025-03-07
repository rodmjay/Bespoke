namespace AssetScope.Api.Middleware.Authorization;

public static class ClaimConstants
{
    // Claim Types
    public const string Workflow = "workflow";
    public const string Admin = "admin";
    public const string Drafts = "drafts";
    public const string Reports = "reports";
    public const string Approver = "approver";
    public const string Attachments = "attachments";
    public const string Funding = "funding";

    // Claim Values
    public const string Manage = "manage";
    public const string View = "view";
    public const string Override = "override";
    public const string Append = "append";
    public const string Action = "action";
    public const string Revert = "revert";
}