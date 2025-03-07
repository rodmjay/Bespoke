namespace Bespoke.Core.Models
{
    /// <summary>
    /// Base model for the Core library
    /// </summary>
    public class CoreModel
    {
        public string Id { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
