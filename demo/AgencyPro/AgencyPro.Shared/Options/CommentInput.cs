namespace AgencyPro.Shared.Options
{
    public class CommentInput
    {
        public string Body { get; set; } = null!;
        public virtual bool Internal { get; set; }
    }
}