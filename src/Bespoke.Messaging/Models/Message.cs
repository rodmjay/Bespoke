namespace Bespoke.Messaging.Models
{
    /// <summary>
    /// Base message model for the Messaging library
    /// </summary>
    public class Message
    {
        public string Id { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public string SenderAddress { get; set; } = string.Empty;
        public List<string> RecipientAddresses { get; set; } = new List<string>();
    }
}
