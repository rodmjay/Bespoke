#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using IdentityPro.Shared.Interfaces;

namespace IdentityPro.Shared.Models
{
    public class UserLoginDto : IUserLogin
    {
        public string LoginProvider { get; set; } = string.Empty;
        public string ProviderKey { get; set; } = string.Empty;
        // Implement additional properties as defined in IUserLogin
    }
}
