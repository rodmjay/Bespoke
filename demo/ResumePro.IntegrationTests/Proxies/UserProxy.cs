#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class UserProxy : BaseProxy, IUserController
{
    public UserProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public Task<UserOutput> GetUser()
    {
        throw new NotImplementedException();
    }
}