#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using IdentityPro.Shared.Interfaces;

namespace IdentityPro.Shared.Models
{
    public class RoleClaimDto : IRoleClaim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; } = string.Empty;
        public string ClaimValue { get; set; } = string.Empty;
        // Implement additional properties as defined in IRoleClaim
    }
}
