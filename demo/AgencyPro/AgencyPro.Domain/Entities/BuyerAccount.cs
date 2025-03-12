namespace AgencyPro.Domain.Entities;

public class BuyerAccount : BaseEntity<BuyerAccount>, IBuyerAccount
{
    private ICollection<CustomerCard> _cards = null!;

    private ICollection<StripeCharge> _charges = null!;


    private ICollection<StripeInvoice> _invoices = null!;
    private ICollection<StripeInvoiceItem> _items = null!;


    private ICollection<StripeSource> _sources = null!;


    public virtual OrganizationBuyerAccount OrganizationBuyerAccount { get; set; } = null!;
    public virtual IndividualBuyerAccount IndividualBuyerAccount { get; set; } = null!;

    public virtual ICollection<StripeInvoiceItem> InvoiceItems
    {
        get => _items ??= new Collection<StripeInvoiceItem>();
        set => _items = value;
    }

    public virtual ICollection<StripeSource> PaymentSources
    {
        get => _sources ??= new Collection<StripeSource>();
        set => _sources = value;
    }

    public virtual ICollection<StripeInvoice> Invoices
    {
        get => _invoices ??= new Collection<StripeInvoice>();
        set => _invoices = value;
    }

    public virtual ICollection<StripeCharge> Charges
    {
        get => _charges ??= new Collection<StripeCharge>();
        set => _charges = value;
    }

    public ICollection<StripeCheckoutSession> CheckoutSessions { get; set; } = new List<StripeCheckoutSession>();

    public virtual ICollection<CustomerCard> Cards
    {
        get => _cards ??= new Collection<CustomerCard>();
        set => _cards = value;
    }

    public bool IsDeleted { get; set; }

    public decimal Balance { get; set; }
    public bool Delinquent { get; set; }

    public string Id { get; set; } = null!;
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }

    public override void Configure(EntityTypeBuilder<BuyerAccount> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasQueryFilter(x => x.IsDeleted == false);
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.Balance).HasColumnType("Money");

        builder.HasOne(x => x.IndividualBuyerAccount)
            .WithOne(x => x.BuyerAccount)
            .HasForeignKey<IndividualBuyerAccount>(x => x.BuyerAccountId);

        builder.HasOne(x => x.OrganizationBuyerAccount)
            .WithOne(x => x.BuyerAccount)
            .HasForeignKey<OrganizationBuyerAccount>(x => x.BuyerAccountId);

        builder.HasMany(x => x.Invoices)
            .WithOne(x => x.BuyerAccount)
            .HasForeignKey(x => x.CustomerId);

        builder.HasMany(x => x.PaymentSources)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);

        builder.HasMany(x => x.InvoiceItems)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);

        builder.HasMany(x => x.CheckoutSessions)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);

        builder.HasMany(x => x.Charges)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);

        builder.HasMany(x => x.Cards)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);
    }
}