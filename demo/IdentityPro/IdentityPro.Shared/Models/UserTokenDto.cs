#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using IdentityPro.Shared.Interfaces;

namespace IdentityPro.Shared.Models
{
    public class UserTokenDto : IUserToken
    {
        public int UserId { get; set; }
        public string LoginProvider { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        // Implement additional properties as defined in IUserToken
    }
}
