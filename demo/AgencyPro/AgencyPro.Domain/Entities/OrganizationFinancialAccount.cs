﻿namespace AgencyPro.Domain.Entities;

public class OrganizationFinancialAccount : BaseEntity<OrganizationFinancialAccount>
{
    public Guid Id { get; set; }

    public FinancialAccount FinancialAccount { get; set; }
    public Organization Organization { get; set; }

    public string FinancialAccountId { get; set; } = null!;


    public override void Configure(EntityTypeBuilder<OrganizationFinancialAccount> builder)
    {
        builder.HasOne(x => x.Organization)
            .WithOne(x => x.OrganizationFinancialAccount)
            .HasForeignKey<OrganizationFinancialAccount>(x => x.Id)
            .IsRequired();

        builder.HasOne(x => x.FinancialAccount)
            .WithOne(x => x.OrganizationFinancialAccount)
            .HasForeignKey<OrganizationFinancialAccount>(x => x.FinancialAccountId)
            .IsRequired();
    }
}