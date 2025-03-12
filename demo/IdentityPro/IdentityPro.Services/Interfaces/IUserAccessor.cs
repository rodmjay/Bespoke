using System.Security.Claims;
using IdentityPro.Shared.Models;

namespace IdentityPro.Services.Interfaces;

public interface IUserAccessor
{
    Task<UserDto> GetUser(ClaimsPrincipal principal);
}