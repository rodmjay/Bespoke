namespace AgencyPro.Shared.Models;

public class IndividualPayoutIntentOutput : PayoutViewModel, IIndividualPayoutIntent
{
    public string RecipientName { get; set; }
    public Guid PersonId { get; set; }
}