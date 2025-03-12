namespace AgencyPro.Domain.Entities;

public class StripeTransfer : BaseEntity<StripeTransfer>, IStripeTransfer
{
    public FinancialAccount DestinationAccount { get; set; }
    public bool IsDeleted { get; set; }
    public InvoiceTransfer InvoiceTransfer { get; set; }
    public BonusTransfer BonusTransfer { get; set; }
    public DateTimeOffset Created { get; set; }
    public string Id { get; set; } = null!;
    public decimal Amount { get; set; }
    public decimal AmountReversed { get; set; }
    public string Description { get; set; } = null!;

    public string DestinationId { get; set; } = null!;

    public string DestinationPaymentId { get; set; } = null!;

    public override void Configure(EntityTypeBuilder<StripeTransfer> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.HasOne(x => x.DestinationAccount)
            .WithMany(x => x.Transfers)
            .HasForeignKey(x => x.DestinationId);
    }
}