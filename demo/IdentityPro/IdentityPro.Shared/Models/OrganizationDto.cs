#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using IdentityPro.Shared.Interfaces;

namespace IdentityPro.Shared.Models
{
    public class OrganizationDto : IOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // Implement additional properties as defined in IOrganization
    }
}
