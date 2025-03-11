#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using AgencyPro.Domain.Entities;
using Bespoke.Data;
using Bespoke.Data.Attributes;
using Bespoke.Data.Bases;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

[assembly: SeedAssembly]

namespace AgencyPro.Data.Contexts;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public sealed class ApplicationContext : BaseContext<ApplicationContext>
{
    public ApplicationContext(
        DbContextOptions<ApplicationContext> options, IOptions<DbSettings> settings) : base(options, settings)
    {
    }

    protected override void SeedDatabase(ModelBuilder builder)
    {
       
    }

    protected override void PreModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(Organization).Assembly);
        
        // Configure a default column type for all decimal properties
        foreach (var property in builder.Model.GetEntityTypes()
                                        .SelectMany(t => t.GetProperties())
                                        .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18,2)");
        }
        
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            // Loop over all foreign keys for each entity type
            foreach (var foreignKey in entityType.GetForeignKeys())
            {
                // Set the delete behavior to NoAction
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
        
        // Manually ignore all entities
        builder.Ignore<AccountCard>();
        builder.Ignore<AccountManager>();
        builder.Ignore<BillingCategory>();
        builder.Ignore<BonusTransfer>();
        builder.Ignore<BuyerAccount>();
        builder.Ignore<Candidate>();
        builder.Ignore<CandidateNotification>();
        builder.Ignore<Category>();
        builder.Ignore<CategoryBillingCategory>();
        builder.Ignore<CategoryPaymentTerm>();
        builder.Ignore<CategoryPosition>();
        builder.Ignore<CategorySkill>();
        builder.Ignore<Comment>();
        builder.Ignore<Contract>();
        builder.Ignore<ContractNotification>();
        builder.Ignore<Contractor>();
        builder.Ignore<ContractorSkill>();
        builder.Ignore<Customer>();
        builder.Ignore<CustomerAccount>();
        builder.Ignore<CustomerCard>();
        builder.Ignore<FinancialAccount>();
        builder.Ignore<FixedPriceProposal>();
        builder.Ignore<IndividualBonusIntent>();
        builder.Ignore<IndividualBuyerAccount>();
        builder.Ignore<IndividualFinancialAccount>();
        builder.Ignore<IndividualPayoutIntent>();
        builder.Ignore<InvoiceMatrix>();
        builder.Ignore<InvoiceTransfer>();
        builder.Ignore<Lead>();
        builder.Ignore<LeadMatrix>();
        builder.Ignore<LeadNotification>();
        builder.Ignore<Level>();
        builder.Ignore<Marketer>();
        builder.Ignore<MarketingAgreement>();
        builder.Ignore<MarketingOrganization>();
        builder.Ignore<Notification>();
        builder.Ignore<Organization>();
        builder.Ignore<OrganizationAccountManager>();
        builder.Ignore<OrganizationBillingCategory>();
        builder.Ignore<OrganizationBonusIntent>();
        builder.Ignore<OrganizationBuyerAccount>();
        builder.Ignore<OrganizationContractor>();
        builder.Ignore<OrganizationCustomer>();
        builder.Ignore<OrganizationFinancialAccount>();
        builder.Ignore<OrganizationMarketer>();
        builder.Ignore<OrganizationPaymentTerm>();
        builder.Ignore<OrganizationPayoutIntent>();
        builder.Ignore<OrganizationPerson>();
        builder.Ignore<OrganizationPosition>();
        builder.Ignore<OrganizationProjectManager>();
        builder.Ignore<OrganizationRecruiter>();
        builder.Ignore<OrganizationSetting>();
        builder.Ignore<OrganizationSkill>();
        builder.Ignore<OrganizationSubscription>();
        builder.Ignore<PaymentTerm>();
        builder.Ignore<Person>();
        builder.Ignore<PersonNotification>();
        builder.Ignore<Position>();
        builder.Ignore<PremiumOrganization>();
        builder.Ignore<Project>();
        builder.Ignore<ProjectBillingCategory>();
        builder.Ignore<ProjectInvoice>();
        builder.Ignore<ProjectInvoiceAdditionalExpense>();
        builder.Ignore<ProjectManager>();
        builder.Ignore<ProjectNotification>();
        builder.Ignore<ProjectRetainerIntent>();
        builder.Ignore<ProposalAcceptance>();
        builder.Ignore<ProposalNotification>();
        builder.Ignore<ProposalWorkOrder>();
        builder.Ignore<ProviderOrganization>();
        builder.Ignore<Recruiter>();
        builder.Ignore<RecruitingAgreement>();
        builder.Ignore<RecruitingOrganization>();
        builder.Ignore<ServiceAgreement>();
        builder.Ignore<Skill>();
        builder.Ignore<Story>();
        builder.Ignore<StoryNotification>();
        builder.Ignore<StripeBalanceTransaction>();
        builder.Ignore<StripeCard>();
        builder.Ignore<StripeCharge>();
        builder.Ignore<StripeCheckoutSession>();
        builder.Ignore<StripeInvoice>();
        builder.Ignore<StripeInvoiceItem>();
        builder.Ignore<StripeInvoiceLine>();
        builder.Ignore<StripePaymentIntent>();
        builder.Ignore<StripePayout>();
        builder.Ignore<StripeSource>();
        builder.Ignore<StripeSubscription>();
        builder.Ignore<StripeSubscriptionItem>();
        builder.Ignore<StripeTransfer>();
        builder.Ignore<SystemNotification>();
        builder.Ignore<TimeEntry>();
        builder.Ignore<TimeEntryNotification>();
        builder.Ignore<TimeMatrix>();
        builder.Ignore<User>();
        builder.Ignore<UserNotification>();
        builder.Ignore<WorkOrder>();
        builder.Ignore<WorkOrderNotification>();
    }


}
