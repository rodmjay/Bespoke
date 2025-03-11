#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.IntegrationTesting.Bases;
using Bespoke.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using ResumePro.Api.Interfaces;
using ResumePro.Shared.Models;
using ResumePro.Shared.Options;

namespace ResumePro.IntegrationTests.Proxies;

public sealed class CertificationsProxy : BaseProxy, ICertificationsController
{
    public CertificationsProxy(HttpClient httpClient) : base(httpClient)
    {
    }

    public  Task<CertificationDto> Get(int personId, int certificationId)
    {
        throw new NotImplementedException();
    }

    public  Task<List<CertificationDto>> Get(int personId)
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<CertificationDto>> CreateCertification(int personId, CertificationOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<ActionResult<CertificationDto>> Update(int personId, int certificationId, CertificationOptions options)
    {
        throw new NotImplementedException();
    }

    public  Task<Result> Delete(int personId, int certificationId)
    {
        throw new NotImplementedException();
    }
}