namespace AgencyPro.Shared.Models
{
    public class IndividualPayoutIntentOutput : PayoutViewModel, IIndividualPayoutIntent
    {
        public Guid PersonId { get; set; }
        public string RecipientName { get; set; }
    }
}
