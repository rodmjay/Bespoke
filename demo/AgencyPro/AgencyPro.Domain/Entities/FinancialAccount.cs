﻿namespace AgencyPro.Domain.Entities;

public class FinancialAccount : BaseEntity<FinancialAccount>, IFinancialAccount
{
    public string RefreshToken { get; set; } = null!;

    public string AccessToken { get; set; } = null!;
    public string StripePublishableKey { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    // public ICollection<Payment> Payments { get; set; }

    public virtual OrganizationFinancialAccount OrganizationFinancialAccount { get; set; }

    public virtual IndividualFinancialAccount IndividualFinancialAccount { get; set; }

    public bool IsDeleted { get; set; }

    public string CardIssuingCapabilityStatus { get; set; } = null!;

    public string CardPaymentsCapabilityStatus { get; set; } = null!;
    public string TransfersCapabilityStatus { get; set; } = null!;

    // public string Blob { get; set; }
    public string DefaultCurrency { get; set; } = null!;
    public string MerchantCategoryCode { get; set; } = null!;
    public string SupportEmail { get; set; } = null!;
    public string SupportPhone { get; set; } = null!;

    public ICollection<StripeCharge> DestinationCharges { get; set; }

    public ICollection<StripeTransfer> Transfers { get; set; }
    public ICollection<AccountCard> Cards { get; set; }

    public string AccountId { get; set; } = null!;
    public FinancialAccountStatus Status { get; set; }
    public bool ChargesEnabled { get; set; }
    public bool PayoutsEnabled { get; set; }

    public override void Configure(EntityTypeBuilder<FinancialAccount> builder)
    {
        builder.HasKey(x => x.AccountId);

        builder.HasQueryFilter(x => x.IsDeleted == false);

        builder.Property(x => x.AccountId).IsRequired();

        builder.HasOne(x => x.IndividualFinancialAccount)
            .WithOne(x => x.FinancialAccount)
            .HasForeignKey<IndividualFinancialAccount>(x => x.FinancialAccountId);

        builder.HasOne(x => x.OrganizationFinancialAccount)
            .WithOne(x => x.FinancialAccount)
            .HasForeignKey<OrganizationFinancialAccount>(x => x.FinancialAccountId);

        builder.HasMany(x => x.DestinationCharges)
            .WithOne(x => x.Destination)
            .HasForeignKey(x => x.DestinationId);

        builder.HasMany(x => x.Transfers)
            .WithOne(x => x.DestinationAccount)
            .HasForeignKey(x => x.DestinationId);

        builder.HasMany(x => x.Cards)
            .WithOne(x => x.FinancialAccount)
            .HasForeignKey(x => x.AccountId);
    }
}