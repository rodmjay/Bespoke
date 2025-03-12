using AgencyPro.Shared.Options;

namespace AgencyPro.Shared.Models;

public class CommentOutput : CommentInput, IComment
{
    public Guid PersonId { get; set; }
    public Guid OrganizationId { get; set; }
    public string PersonName { get; set; } = null!;
    public string PersonImageUrl { get; set; } = null!;
    public string OrganizationName { get; set; } = null!;
    public string OrganizationImageUrl { get; set; } = null!;

    public DateTimeOffset Created { get; set; }

    public override bool Internal { get; set; }
}