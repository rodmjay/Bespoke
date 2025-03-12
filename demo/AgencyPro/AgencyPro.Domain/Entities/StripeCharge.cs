namespace AgencyPro.Domain.Entities;

public class StripeCharge : BaseEntity<StripeCharge>, IStripeCharge
{
    public StripeInvoice Invoice { get; set; }
    public bool IsDeleted { get; set; }

    public FinancialAccount Destination { get; set; }
    public BuyerAccount Customer { get; set; }
    public StripePaymentIntent PaymentIntent { get; set; }
    public long OutcomeRiskScore { get; set; }
    public string OutcomeRiskLevel { get; set; } = null!;


    public ProjectRetainerIntent RetainerIntent { get; set; }
    public Guid? ProjectId { get; set; }
    public string Id { get; set; } = null!;
    public bool Disputed { get; set; }
    public bool Paid { get; set; }

    public string InvoiceId { get; set; } = null!;


    public string OrderId { get; set; } = null!;
    public string ReceiptEmail { get; set; } = null!;
    public string ReceiptUrl { get; set; } = null!;
    public string DestinationId { get; set; } = null!;
    public string Description { get; set; } = null!;

    public string BalanceTransactionId { get; set; } = null!;
    public bool? Captured { get; set; }
    public string CustomerId { get; set; } = null!;

    public string OnBehalfOfId { get; set; } = null!;
    public bool Refunded { get; set; }
    public string StatementDescriptorSuffix { get; set; } = null!;
    public string StatementDescriptor { get; set; } = null!;

    public string PaymentIntentId { get; set; } = null!;
    public string OutcomeType { get; set; } = null!;
    public string OutcomeSellerMessage { get; set; } = null!;
    public string OutcomeReason { get; set; } = null!;
    public string OutcomeNetworkStatus { get; set; } = null!;
    public string ReceiptNumber { get; set; } = null!;
    public decimal Amount { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public override void Configure(EntityTypeBuilder<StripeCharge> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.HasOne(x => x.Destination)
            .WithMany(x => x.DestinationCharges)
            .HasForeignKey(x => x.DestinationId);

        builder.HasOne(x => x.RetainerIntent)
            .WithMany(x => x.Credits)
            .HasForeignKey(x => x.ProjectId)
            .IsRequired(false);


        builder.HasOne(x => x.Customer)
            .WithMany(x => x.Charges)
            .HasForeignKey(x => x.CustomerId);
    }
}