using System.Security.Claims;
using AssetScope.Domain;

namespace AssetScope.Api.Middleware.Authorization;

public static class ClaimsConfiguration
{
    public static readonly Dictionary<string, List<Claim>> RightsToClaimsMap = new()
    {
        {
            nameof(AgencyUser.HasSuperAdminRights), new List<Claim>
            {
                new(ClaimConstants.Workflow, ClaimConstants.Manage)
            }
        },
        {
            nameof(AgencyUser.HasAdminRights), new List<Claim>
            {
                new(ClaimConstants.Admin, ClaimConstants.Manage),
                new(ClaimConstants.Approver, ClaimConstants.Action)
            }
        },
        {
            nameof(AgencyUser.HasEntryApproverRights), new List<Claim>
            {
                new(ClaimConstants.Drafts, ClaimConstants.Manage),
                new(ClaimConstants.Reports, ClaimConstants.View)
            }
        },
        {
            nameof(AgencyUser.HasContractApproverRights), new List<Claim>
            {
                new(ClaimConstants.Approver, ClaimConstants.Override),
                new(ClaimConstants.Attachments, ClaimConstants.Manage),
                new(ClaimConstants.Approver, ClaimConstants.Action)
            }
        },
        {
            nameof(AgencyUser.HasFinanceTeamApproverRights), new List<Claim>
            {
                new(ClaimConstants.Attachments, ClaimConstants.Append),
                new(ClaimConstants.Approver, ClaimConstants.Action)
            }
        },
        {
            nameof(AgencyUser.HasSectionChiefRights), new List<Claim>
            {
                new(ClaimConstants.Attachments, ClaimConstants.Append),
                new(ClaimConstants.Approver, ClaimConstants.Action),
                new(ClaimConstants.Workflow, ClaimConstants.Revert)
            }
        },
        {
            nameof(AgencyUser.HasControllerRights), new List<Claim>
            {
                new(ClaimConstants.Attachments, ClaimConstants.Append),
                new(ClaimConstants.Approver, ClaimConstants.Action),
                new(ClaimConstants.Workflow, ClaimConstants.Revert),
                new(ClaimConstants.Funding, ClaimConstants.Manage)
                // 1. fiscal year
                // 2. project number
                // 3. dollar amount
            }
        }
    };
}