using AssetScope.Shared.Enums;
using AssetScope.Shared.Interfaces;

namespace AssetScope.Shared.Extensions;

public static class UserInfoExtensions
{
    public static bool CanManageDrafts(this IPermissions user)
    {
        return true;
    }

    public static bool CanSubmitContract(this IPermissions user, IContractItem contract)
    {
        if (contract.State == ContractState.Draft)
            if (contract.UserId == user.Id)
                return true;

        return false;
    }

    public static bool CanDuplicateContract(this IPermissions user, IContractItem contract)
    {
        if (user.HasContractApproverRights) return true;
        if (contract.State == ContractState.Draft)
            if (user.Id == contract.UserId)
                return true;

        return false;
    }

    public static bool CanDeleteContract(this IPermissions user, IContractItem contract)
    {
        if (contract.UserId == user.Id && contract.State == ContractState.Draft)
        {
            if (contract.ReturnedToDraft) return false;
            return true;
        }

        return false;
    }

    public static bool CanCancelContract(this IPermissions user, IContractItem contract)
    {
        if (contract.State == ContractState.Completed)
            if (user.HasAdminRights)
                return true;

        return false;
    }


    public static bool CanTerminateContract(this IPermissions user, IContractItem contract)
    {
        if (contract.State == ContractState.Active)
            if (user.HasAdminRights)
                return true;

        return false;
    }

    public static bool CanUnSubmitContract(this IPermissions user, IContractItem contract)
    {
        if (contract.State == ContractState.InProcess)
            if (user.HasFinanceTeamApproverRights || user.HasContractApproverRights)
                return true;

        return false;
    }

    public static bool CanEditContract(this IPermissions user, IContractItem contract)
    {
        if (user.HasAdminRights)
            return true;

        if (contract.State == ContractState.Draft)
            if (contract.UserId == user.Id || user.HasContractApproverRights)
                return true;

        if (contract.State == ContractState.InProcess)
            if (user.HasContractApproverRights)
                return true;

        return false;
    }

    public static bool CanUpdateAttachment(this IPermissions user, IContractItem contract,
        IContractItemAttachment attachment)
    {
        if (user.HasAdminRights) return true;
        if (contract.State == ContractState.Draft)
            if (contract.UserId == user.Id)
                if (attachment.UserId == user.Id)
                    return true;

        return false;
    }

    public static bool CanDownloadAttachment(this IPermissions user, IContractItem contract,
        IContractItemAttachment attachment)
    {
        if (user.HasAdminRights) return true;
        if (contract.State == ContractState.Draft)
            if (contract.UserId == user.Id)
                if (attachment.UserId == user.Id)
                    return true;

        if (attachment.RestrictDownloadToFinanceOnly)
            if (user.HasFinanceTeamApproverRights)
                return true;

        return false;
    }

    public static bool CanDeleteAttachment(this IPermissions user, IContractItem contract,
        IContractItemAttachment attachment)
    {
        if (user.HasAdminRights) return true;
        if (contract.State == ContractState.Draft)
            if (contract.UserId == user.Id)
                if (attachment.UserId == user.Id)
                    return true;

        return false;
    }

    public static bool CanReassign(this IPermissions user, IContractItem contract)
    {
        if (user.HasAdminRights) return true;

        return false;
    }

    public static bool CanAttachDocumentToContract(this IPermissions user, IContractItem contract)
    {
        // Draft State: Only the contract creator can edit their draft.
        if (contract.State == ContractState.Draft)
            if (contract.UserId == user.Id)
                return true;

        if (contract.State == ContractState.InProcess)
            if (user.HasFinanceTeamApproverRights)
                return true;

        // Add more conditions as needed for other roles and states.
        return false;
    }

    public static bool CanSetCFO(this IPermissions user)
    {
        if (user.HasAdminRights) return true;
        return false;
    }

    public static bool CanUpdateUser(this IPermissions user)
    {
        if (user.HasAdminRights) return true;

        return false;
    }

    public static bool CanManageEmailTemplates(this IPermissions user)
    {
        return user.HasAdminRights;
    }

    public static bool CanOverrideApproval(this IPermissions user, IContractItem contract)
    {
        if (contract.State == ContractState.InProcess)
            if (user.HasContractApproverRights)
                return true;

        return false;
    }

    public static bool CanAssignContractManager(this IPermissions user, IContractItem contract)
    {
        if (contract.State == ContractState.InProcess)
            if (user.HasContractApproverRights)
                return true;

        return false;
    }

    public static bool CanRejectContract(this IPermissions user, IContractItem contract)
    {
        if (contract.State == ContractState.InProcess)
            if (user.HasContractApproverRights)
                return true;

        return false;
    }
}