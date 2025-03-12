namespace AgencyPro.Shared.Extensions;

public static class UserInfoExtensions
{
    public static bool HasPermission(this UserInfo user)
    {
        return true;
    }
}

public static class SecurityExtensions
{
    public static bool CanCreateContract(this UserInfo user)
    {
        return user.HasPermission();
    }
}