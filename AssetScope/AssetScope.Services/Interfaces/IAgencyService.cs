using AssetScope.Domain;
using AssetScope.Shared.Interfaces;
using AssetScope.Shared.Models;
using AssetScope.Shared.Options;
using AssetScope.Shared.Queries;
using Bespoke.Services.Interfaces;
using Bespoke.Shared.Common;
using OneOf;

namespace AssetScope.Services.Interfaces;

public interface IAgencyService : IService<AgencyUser>
{
    public Task<T> GetUser<T>(int userId) where T : IUserInfo;
    public Task<List<T>> GetUsers<T>() where T : IAgencyUser;
    public Task<PagedList<T>> SearchUsers<T>(UserInfo userInfo, UserQuery userOptions, PagingQuery paging)
        where T : IAgencyUser;
    Task<OneOf<AgencyUserDto, Result>> UpdateUser(UserInfo userInfo, int userId, AgencyUserOptions options);
}