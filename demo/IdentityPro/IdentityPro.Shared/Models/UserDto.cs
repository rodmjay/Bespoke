#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using IdentityPro.Shared.Interfaces;

namespace IdentityPro.Shared.Models;

public class UserDto : IUser
{
    public string OrganizationName { get; set; }
    public int OrganizationId { get; set; }
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}