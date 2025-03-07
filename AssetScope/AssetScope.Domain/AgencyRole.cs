using System.ComponentModel.DataAnnotations.Schema;
using AssetScope.Shared.Enums;
using Bespoke.Data.Enums;
using Bespoke.Data.Interfaces;

namespace AssetScope.Domain;

public class AgencyRole : IObjectState
{
    public int AgencyUserId { get; set; }
    public AgencyUser AgencyUser { get; set; } = null!;

    public AgencyRoleEnum Role { get; set; }

    [NotMapped] public ObjectState ObjectState { get; set; }
}
