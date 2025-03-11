namespace AgencyPro.Shared.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public abstract class BaseResult
    {
        public bool Succeeded { get; set; }
        public string ErrorMessage { get; set; }
    }
}
