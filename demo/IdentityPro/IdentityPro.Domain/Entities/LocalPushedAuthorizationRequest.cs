using System;

namespace IdentityPro.Domain.Entities;

public class LocalPushedAuthorizationRequest
{
    public string Id { get; set; }
    public string RequestUri { get; set; }
    public DateTime ExpiresAtUtc { get; set; }
    public string Parameters { get; set; }
}
