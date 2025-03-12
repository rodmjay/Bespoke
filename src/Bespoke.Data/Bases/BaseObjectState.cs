using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Bespoke.Data.Bases;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public abstract class BaseObjectState : IObjectState
{
    [NotMapped] [IgnoreDataMember] public ObjectState ObjectState { get; set; }
}