using Bespoke.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityPro.Services.Interfaces;

public interface IRoleService : IService<Role>,
    IRoleStore<Role>,
    IQueryableRoleStore<Role>,
    IRoleClaimStore<Role>
{
}