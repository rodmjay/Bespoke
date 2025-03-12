using System.Security.Claims;

namespace AgencyPro.Shared.Interfaces;

public interface IUserAccessor
{
    Task<IUser> GetUser(ClaimsPrincipal principal);
}