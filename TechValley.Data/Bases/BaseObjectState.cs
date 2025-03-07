#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace TechValley.Data.Bases;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public abstract class BaseObjectState : IObjectState
{
    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}