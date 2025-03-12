using AgencyPro.Domain.Events;
using AgencyPro.Services.Organizations.Interfaces;
using AgencyPro.Shared.Extensions;
using Bespoke.Core;
using Bespoke.Data.Extensions;
using Bespoke.Services.Bases;
using Bespoke.Shared.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OneOf;

namespace AgencyPro.Services.Organizations.Implementation;

public class OrganizationService : BaseService<Organization>, IOrganizationService
{
    private readonly IEventAggregator _eventAggregator;

    public OrganizationService(IServiceProvider serviceProvider, IEventAggregator eventAggregator)
        : base(serviceProvider)
    {
        _eventAggregator = eventAggregator;
    }

    public async Task<OneOf<OrganizationDto, Result>> CreateOrganizationAsync(UserInfo user, OrganizationOptions input,
        CancellationToken ct = default)
    {
        Logger.LogInformation(GetLogMessage("Input: {@input}"), input);

        var organization = new Organization
        {
            Name = input.Name,
            Description = input.Description,
            ImageUrl = input.Iso2
        };

        if (await SaveOrganizationAsync(organization))
        {
            PublishOrganizationCreatedEvent(organization.Id, user.Id);
            return await GetOrganization<OrganizationDto>(user, organization.Id, ct);
        }

        return Result.Failed();
    }

    public async Task<T> GetOrganization<T>(UserInfo user, Guid id, CancellationToken ct = default)
        where T : IOrganization
    {
        return await Repository.Queryable()
            .Where(x => x.Id == id)
            .ProjectTo<T>(Mapper)
            .FirstAsync(ct);
    }

    private async Task<bool> SaveOrganizationAsync(Organization organization)
    {
        if (organization.Id == Guid.Empty)
            await Repository.InsertAsync(organization);
        else
            await Repository.UpdateAsync(organization);

        var records = Repository.Commit();
        Logger.LogDebug(GetLogMessage("Updated: {@records}"), records);
        return records > 0;
    }

    private void PublishOrganizationCreatedEvent(Guid organizationId, Guid userId)
    {
        // Publish the event asynchronously without awaiting the task.
        _ = Task.Run(() =>
        {
            _eventAggregator.Publish(new OrganizationCreatedEvent
            {
                OrganizationId = organizationId,
                UserId = userId
            });
        });
    }
}