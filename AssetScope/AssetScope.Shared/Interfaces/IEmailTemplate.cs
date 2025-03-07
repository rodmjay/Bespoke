using AssetScope.Shared.Enums;

namespace AssetScope.Shared.Interfaces;

public interface IEmailTemplate
{
    NotificationType EmailTemplateId { get; set; }
    string EmailSubject { get; set; }
    string EmailTemplateBodyHtml { get; set; }
    string EmailTemplateBodyPlainText { get; set; }
}