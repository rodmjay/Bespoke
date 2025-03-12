namespace AgencyPro.Shared.Interfaces;

public interface IComment
{
    string Body { get; set; }
    bool Internal { get; set; }
}