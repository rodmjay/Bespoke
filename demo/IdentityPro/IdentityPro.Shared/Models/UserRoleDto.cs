#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using IdentityPro.Shared.Interfaces;

namespace IdentityPro.Shared.Models
{
    public class UserRoleDto : IUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        // Implement additional properties as defined in IUserRole
    }
}
