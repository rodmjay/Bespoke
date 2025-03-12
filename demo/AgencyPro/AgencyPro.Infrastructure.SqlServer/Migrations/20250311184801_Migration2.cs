using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgencyPro.Infrastructure.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Category_CategoryId",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Customer_CustomerId",
                table: "Organization");

            migrationBuilder.DropTable(
                name: "AccountCard");

            migrationBuilder.DropTable(
                name: "CandidateNotification");

            migrationBuilder.DropTable(
                name: "CategoryBillingCategory");

            migrationBuilder.DropTable(
                name: "CategoryPaymentTerm");

            migrationBuilder.DropTable(
                name: "CategoryPosition");

            migrationBuilder.DropTable(
                name: "CategorySkill");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "ContractNotification");

            migrationBuilder.DropTable(
                name: "ContractorSkill");

            migrationBuilder.DropTable(
                name: "CustomerCard");

            migrationBuilder.DropTable(
                name: "IndividualBonusIntent");

            migrationBuilder.DropTable(
                name: "IndividualBuyerAccount");

            migrationBuilder.DropTable(
                name: "IndividualFinancialAccount");

            migrationBuilder.DropTable(
                name: "IndividualPayoutIntent");

            migrationBuilder.DropTable(
                name: "LeadNotification");

            migrationBuilder.DropTable(
                name: "MarketingAgreement");

            migrationBuilder.DropTable(
                name: "OrganizationBillingCategory");

            migrationBuilder.DropTable(
                name: "OrganizationBonusIntent");

            migrationBuilder.DropTable(
                name: "OrganizationBuyerAccount");

            migrationBuilder.DropTable(
                name: "OrganizationFinancialAccount");

            migrationBuilder.DropTable(
                name: "OrganizationPaymentTerm");

            migrationBuilder.DropTable(
                name: "OrganizationPayoutIntent");

            migrationBuilder.DropTable(
                name: "OrganizationPosition");

            migrationBuilder.DropTable(
                name: "OrganizationSetting");

            migrationBuilder.DropTable(
                name: "OrganizationSkill");

            migrationBuilder.DropTable(
                name: "OrganizationSubscription");

            migrationBuilder.DropTable(
                name: "PersonNotification");

            migrationBuilder.DropTable(
                name: "PremiumOrganization");

            migrationBuilder.DropTable(
                name: "ProjectBillingCategory");

            migrationBuilder.DropTable(
                name: "ProjectInvoiceAdditionalExpense");

            migrationBuilder.DropTable(
                name: "ProjectNotification");

            migrationBuilder.DropTable(
                name: "ProposalAcceptance");

            migrationBuilder.DropTable(
                name: "ProposalNotification");

            migrationBuilder.DropTable(
                name: "ProposalWorkOrder");

            migrationBuilder.DropTable(
                name: "RecruitingAgreement");

            migrationBuilder.DropTable(
                name: "ServiceAgreement");

            migrationBuilder.DropTable(
                name: "StoryNotification");

            migrationBuilder.DropTable(
                name: "StripeBalanceTransaction");

            migrationBuilder.DropTable(
                name: "StripeCharge");

            migrationBuilder.DropTable(
                name: "StripeCheckoutSession");

            migrationBuilder.DropTable(
                name: "StripeInvoiceLine");

            migrationBuilder.DropTable(
                name: "StripeSource");

            migrationBuilder.DropTable(
                name: "StripeSubscriptionItem");

            migrationBuilder.DropTable(
                name: "SystemNotification");

            migrationBuilder.DropTable(
                name: "TimeEntryNotification");

            migrationBuilder.DropTable(
                name: "UserNotification");

            migrationBuilder.DropTable(
                name: "WorkOrderNotification");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "StripeCard");

            migrationBuilder.DropTable(
                name: "BonusTransfer");

            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Lead");

            migrationBuilder.DropTable(
                name: "InvoiceTransfer");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "ProjectInvoice");

            migrationBuilder.DropTable(
                name: "Proposal");

            migrationBuilder.DropTable(
                name: "StripePayout");

            migrationBuilder.DropTable(
                name: "ProjectRetainerIntent");

            migrationBuilder.DropTable(
                name: "StripePaymentIntent");

            migrationBuilder.DropTable(
                name: "TimeEntry");

            migrationBuilder.DropTable(
                name: "WorkOrder");

            migrationBuilder.DropTable(
                name: "StripeTransfer");

            migrationBuilder.DropTable(
                name: "BillingCategory");

            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "StripeInvoiceItem");

            migrationBuilder.DropTable(
                name: "FinancialAccount");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "StripeInvoice");

            migrationBuilder.DropTable(
                name: "MarketingOrganization");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "RecruitingOrganization");

            migrationBuilder.DropTable(
                name: "BuyerAccount");

            migrationBuilder.DropTable(
                name: "StripeSubscription");

            migrationBuilder.DropTable(
                name: "CustomerAccount");

            migrationBuilder.DropTable(
                name: "OrganizationCustomer");

            migrationBuilder.DropTable(
                name: "PaymentTerm");

            migrationBuilder.DropTable(
                name: "ProviderOrganization");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "OrganizationAccountManager");

            migrationBuilder.DropTable(
                name: "OrganizationContractor");

            migrationBuilder.DropTable(
                name: "OrganizationProjectManager");

            migrationBuilder.DropTable(
                name: "OrganizationMarketer");

            migrationBuilder.DropTable(
                name: "AccountManager");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "ProjectManager");

            migrationBuilder.DropTable(
                name: "Marketer");

            migrationBuilder.DropTable(
                name: "OrganizationRecruiter");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Recruiter");

            migrationBuilder.DropIndex(
                name: "IX_Organization_CategoryId",
                table: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Organization_CustomerId",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[FirstName] + ' ' + [LastName]");

            migrationBuilder.CreateTable(
                name: "AccountManager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountManager_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillingCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    IsStoryBucket = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuyerAccount",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Delinquent = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyerAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountManagerTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Account Manager"),
                    AccountManagerTitlePlural = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Account Managers"),
                    ContractorTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Contractor"),
                    ContractorTitlePlural = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Contractors"),
                    CustomerTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Customer"),
                    CustomerTitlePlural = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Customers"),
                    DefaultAccountManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 5m),
                    DefaultAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 15m),
                    DefaultContractorStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 25m),
                    DefaultMarketerBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 10m),
                    DefaultMarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 2.5m),
                    DefaultMarketingAgencyBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 10m),
                    DefaultMarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 1m),
                    DefaultProjectManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 7.5m),
                    DefaultRecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 2.5m),
                    DefaultRecruitingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 2m),
                    MarketerTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Marketer"),
                    MarketerTitlePlural = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Marketers"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProjectManagerTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Project Manager"),
                    ProjectManagerTitlePlural = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Project Managers"),
                    RecruiterTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Recruiter"),
                    RecruiterTitlePlural = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Recruiters"),
                    Searchable = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    StoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryTitlePlural = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "FinancialAccount",
                columns: table => new
                {
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardIssuingCapabilityStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardPaymentsCapabilityStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChargesEnabled = table.Column<bool>(type: "bit", nullable: false),
                    DefaultCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MerchantCategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayoutsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StripePublishableKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransfersCapabilityStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialAccount", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Marketer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marketer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marketer_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationSetting",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionType = table.Column<byte>(type: "tinyint", nullable: false),
                    MenuType = table.Column<byte>(type: "tinyint", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationSetting", x => new { x.OrganizationId, x.SectionType, x.MenuType });
                    table.ForeignKey(
                        name: "FK_OrganizationSetting_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerm",
                columns: table => new
                {
                    PaymentTermId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NetValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerm", x => x.PaymentTermId);
                });

            migrationBuilder.CreateTable(
                name: "PersonNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonNotification_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PremiumOrganization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremiumOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PremiumOrganization_Organization_Id",
                        column: x => x.Id,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectManager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectManager_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Recruiter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recruiter_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StripeCard",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CvcCheck = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicLast4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpMonth = table.Column<int>(type: "int", nullable: false),
                    ExpYear = table.Column<int>(type: "int", nullable: false),
                    Fingerprint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Funding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Last4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StripePayout",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ArrivalDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Automatic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripePayout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StripeSubscription",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CancelAtPeriodEnd = table.Column<bool>(type: "bit", nullable: false),
                    CanceledAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrialEnd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeSubscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemNotification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNotification_User_PersonId",
                        column: x => x.PersonId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationAccountManager",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAccountManager", x => new { x.OrganizationId, x.AccountManagerId });
                    table.ForeignKey(
                        name: "FK_OrganizationAccountManager_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationAccountManager_OrganizationPerson_OrganizationId_AccountManagerId",
                        columns: x => new { x.OrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_OrganizationAccountManager_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationBillingCategory",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillingCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationBillingCategory", x => new { x.OrganizationId, x.BillingCategoryId });
                    table.ForeignKey(
                        name: "FK_OrganizationBillingCategory_BillingCategory_BillingCategoryId",
                        column: x => x.BillingCategoryId,
                        principalTable: "BillingCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationBillingCategory_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationBuyerAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationBuyerAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationBuyerAccount_BuyerAccount_BuyerAccountId",
                        column: x => x.BuyerAccountId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationBuyerAccount_Organization_Id",
                        column: x => x.Id,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeCheckoutSession",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeCheckoutSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeCheckoutSession_BuyerAccount_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeSource",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<long>(type: "bigint", nullable: true),
                    ClientSecret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeSource_BuyerAccount_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryBillingCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BillingCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryBillingCategory", x => new { x.CategoryId, x.BillingCategoryId });
                    table.ForeignKey(
                        name: "FK_CategoryBillingCategory_BillingCategory_BillingCategoryId",
                        column: x => x.BillingCategoryId,
                        principalTable: "BillingCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryBillingCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "IndividualFinancialAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FinancialAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualFinancialAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualFinancialAccount_FinancialAccount_FinancialAccountId",
                        column: x => x.FinancialAccountId,
                        principalTable: "FinancialAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_IndividualFinancialAccount_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationFinancialAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FinancialAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationFinancialAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationFinancialAccount_FinancialAccount_FinancialAccountId",
                        column: x => x.FinancialAccountId,
                        principalTable: "FinancialAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_OrganizationFinancialAccount_Organization_Id",
                        column: x => x.Id,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeTransfer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DestinationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountReversed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationPaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeTransfer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeTransfer_FinancialAccount_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "FinancialAccount",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationMarketer",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsSystemDefault = table.Column<bool>(type: "bit", nullable: false),
                    MarketerBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReferralCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationMarketer", x => new { x.OrganizationId, x.MarketerId });
                    table.ForeignKey(
                        name: "FK_OrganizationMarketer_Marketer_MarketerId",
                        column: x => x.MarketerId,
                        principalTable: "Marketer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationMarketer_OrganizationPerson_OrganizationId_MarketerId",
                        columns: x => new { x.OrganizationId, x.MarketerId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_OrganizationMarketer_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryPaymentTerm",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PaymentTermId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPaymentTerm", x => new { x.CategoryId, x.PaymentTermId });
                    table.ForeignKey(
                        name: "FK_CategoryPaymentTerm_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_CategoryPaymentTerm_PaymentTerm_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalTable: "PaymentTerm",
                        principalColumn: "PaymentTermId");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationPaymentTerm",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentTermId = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationPaymentTerm", x => new { x.OrganizationId, x.PaymentTermId });
                    table.ForeignKey(
                        name: "FK_OrganizationPaymentTerm_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationPaymentTerm_PaymentTerm_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalTable: "PaymentTerm",
                        principalColumn: "PaymentTermId");
                });

            migrationBuilder.CreateTable(
                name: "CategoryPosition",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPosition", x => new { x.CategoryId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_CategoryPosition_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_CategoryPosition_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Level_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationPosition",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationPosition", x => new { x.OrganizationId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_OrganizationPosition_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationPosition_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationProjectManager",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProjectManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationProjectManager", x => new { x.OrganizationId, x.ProjectManagerId });
                    table.ForeignKey(
                        name: "FK_OrganizationProjectManager_OrganizationPerson_OrganizationId_ProjectManagerId",
                        columns: x => new { x.OrganizationId, x.ProjectManagerId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_OrganizationProjectManager_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationProjectManager_ProjectManager_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "ProjectManager",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationRecruiter",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsSystemDefault = table.Column<bool>(type: "bit", nullable: false),
                    RecruiterBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationRecruiter", x => new { x.OrganizationId, x.RecruiterId });
                    table.ForeignKey(
                        name: "FK_OrganizationRecruiter_OrganizationPerson_OrganizationId_RecruiterId",
                        columns: x => new { x.OrganizationId, x.RecruiterId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_OrganizationRecruiter_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationRecruiter_Recruiter_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategorySkill",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySkill", x => new { x.SkillId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategorySkill_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_CategorySkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountCard",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountCard_FinancialAccount_AccountId",
                        column: x => x.AccountId,
                        principalTable: "FinancialAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_AccountCard_StripeCard_Id",
                        column: x => x.Id,
                        principalTable: "StripeCard",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeBalanceTransaction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PayoutId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AvailableOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gross = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Net = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeBalanceTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeBalanceTransaction_StripePayout_PayoutId",
                        column: x => x.PayoutId,
                        principalTable: "StripePayout",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationSubscription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StripeSubscriptionId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationSubscription_Organization_Id",
                        column: x => x.Id,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationSubscription_StripeSubscription_StripeSubscriptionId",
                        column: x => x.StripeSubscriptionId,
                        principalTable: "StripeSubscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeInvoice",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubscriptionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AmountDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountRemaining = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AttemptCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Attempted = table.Column<bool>(type: "bit", nullable: false),
                    AutomaticCollection = table.Column<bool>(type: "bit", nullable: false),
                    BillingReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    EndingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HostedInvoiceUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoicePdf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StripePaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeInvoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeInvoice_BuyerAccount_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StripeInvoice_StripeSubscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "StripeSubscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeSubscriptionItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubscriptionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PlanId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeSubscriptionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeSubscriptionItem_StripeSubscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "StripeSubscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BonusTransfer",
                columns: table => new
                {
                    TransferId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusTransfer", x => x.TransferId);
                    table.ForeignKey(
                        name: "FK_BonusTransfer_StripeTransfer_TransferId",
                        column: x => x.TransferId,
                        principalTable: "StripeTransfer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_OrganizationMarketer_MarketerOrganizationId_MarketerId",
                        columns: x => new { x.MarketerOrganizationId, x.MarketerId },
                        principalTable: "OrganizationMarketer",
                        principalColumns: new[] { "OrganizationId", "MarketerId" });
                    table.ForeignKey(
                        name: "FK_Customer_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarketingOrganization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultMarketerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CombinedMarketingBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[MarketerBonus]+[MarketingAgencyBonus]+[ServiceFeePerLead]"),
                    CombinedMarketingStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[MarketerStream]+[MarketingAgencyStream]"),
                    Discoverable = table.Column<bool>(type: "bit", nullable: false),
                    MarketerBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceFeePerLead = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingOrganization_OrganizationMarketer_Id_DefaultMarketerId",
                        columns: x => new { x.Id, x.DefaultMarketerId },
                        principalTable: "OrganizationMarketer",
                        principalColumns: new[] { "OrganizationId", "MarketerId" });
                    table.ForeignKey(
                        name: "FK_MarketingOrganization_Organization_Id",
                        column: x => x.Id,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contractor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    HoursAvailable = table.Column<int>(type: "int", nullable: false, defaultValue: 40),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    LastWorkedUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contractor_OrganizationRecruiter_RecruiterOrganizationId_RecruiterId",
                        columns: x => new { x.RecruiterOrganizationId, x.RecruiterId },
                        principalTable: "OrganizationRecruiter",
                        principalColumns: new[] { "OrganizationId", "RecruiterId" });
                    table.ForeignKey(
                        name: "FK_Contractor_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contractor_Recruiter_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecruitingOrganization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultRecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CombinedRecruitingBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[RecruiterBonus]+[RecruitingAgencyBonus]+[ServiceFeePerLead]"),
                    CombinedRecruitingStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[RecruiterStream]+[RecruitingAgencyStream]"),
                    Discoverable = table.Column<bool>(type: "bit", nullable: false),
                    RecruiterBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingAgencyBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceFeePerLead = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitingOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecruitingOrganization_OrganizationRecruiter_Id_DefaultRecruiterId",
                        columns: x => new { x.Id, x.DefaultRecruiterId },
                        principalTable: "OrganizationRecruiter",
                        principalColumns: new[] { "OrganizationId", "RecruiterId" });
                    table.ForeignKey(
                        name: "FK_RecruitingOrganization_Organization_Id",
                        column: x => x.Id,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceTransfer",
                columns: table => new
                {
                    TransferId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceTransfer", x => x.TransferId);
                    table.ForeignKey(
                        name: "FK_InvoiceTransfer_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceTransfer_StripeTransfer_TransferId",
                        column: x => x.TransferId,
                        principalTable: "StripeTransfer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripePaymentIntent",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountCapturable = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CancelledAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaptureMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmationMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TransferGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripePaymentIntent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripePaymentIntent_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerCard",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerCard_BuyerAccount_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerCard_Customer_CustomerEntityId",
                        column: x => x.CustomerEntityId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerCard_StripeCard_Id",
                        column: x => x.Id,
                        principalTable: "StripeCard",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IndividualBuyerAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualBuyerAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualBuyerAccount_BuyerAccount_BuyerAccountId",
                        column: x => x.BuyerAccountId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndividualBuyerAccount_Customer_Id",
                        column: x => x.Id,
                        principalTable: "Customer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationCustomer",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationCustomer", x => new { x.OrganizationId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_OrganizationCustomer_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationCustomer_OrganizationPerson_OrganizationId_CustomerId",
                        columns: x => new { x.OrganizationId, x.CustomerId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_OrganizationCustomer_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractorSkill",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SelfAssessment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorSkill", x => new { x.SkillId, x.ContractorId });
                    table.ForeignKey(
                        name: "FK_ContractorSkill_Contractor_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractorSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationContractor",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    AutoApproveTimeEntries = table.Column<bool>(type: "bit", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractorStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    PortfolioMediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationContractor", x => new { x.OrganizationId, x.ContractorId });
                    table.ForeignKey(
                        name: "FK_OrganizationContractor_Contractor_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationContractor_Level_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Level",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationContractor_OrganizationPerson_OrganizationId_ContractorId",
                        columns: x => new { x.OrganizationId, x.ContractorId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_OrganizationContractor_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationContractor_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProviderOrganization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultAccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultContractorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AutoApproveTimeEntries = table.Column<bool>(type: "bit", nullable: false),
                    ContractorInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractorStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discoverable = table.Column<bool>(type: "bit", nullable: false),
                    EstimationBasis = table.Column<int>(type: "int", nullable: false),
                    FutureDaysAllowed = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MarketerInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousDaysAllowed = table.Column<int>(type: "int", nullable: false, defaultValue: 14),
                    ProjectManagerInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProviderInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecruiterInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SystemStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderOrganization_OrganizationAccountManager_Id_DefaultAccountManagerId",
                        columns: x => new { x.Id, x.DefaultAccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_ProviderOrganization_OrganizationContractor_Id_DefaultContractorId",
                        columns: x => new { x.Id, x.DefaultContractorId },
                        principalTable: "OrganizationContractor",
                        principalColumns: new[] { "OrganizationId", "ContractorId" });
                    table.ForeignKey(
                        name: "FK_ProviderOrganization_OrganizationProjectManager_Id_DefaultProjectManagerId",
                        columns: x => new { x.Id, x.DefaultProjectManagerId },
                        principalTable: "OrganizationProjectManager",
                        principalColumns: new[] { "OrganizationId", "ProjectManagerId" });
                    table.ForeignKey(
                        name: "FK_ProviderOrganization_Organization_Id",
                        column: x => x.Id,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsContacted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Iso2 = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinceState = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    RecruiterBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingAgencyBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RejectionDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RejectionReason = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidate_OrganizationProjectManager_ProjectManagerOrganizationId_ProjectManagerId",
                        columns: x => new { x.ProjectManagerOrganizationId, x.ProjectManagerId },
                        principalTable: "OrganizationProjectManager",
                        principalColumns: new[] { "OrganizationId", "ProjectManagerId" });
                    table.ForeignKey(
                        name: "FK_Candidate_OrganizationRecruiter_RecruiterOrganizationId_RecruiterId",
                        columns: x => new { x.RecruiterOrganizationId, x.RecruiterId },
                        principalTable: "OrganizationRecruiter",
                        principalColumns: new[] { "OrganizationId", "RecruiterId" });
                    table.ForeignKey(
                        name: "FK_Candidate_Organization_RecruiterOrganizationId",
                        column: x => x.RecruiterOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Candidate_ProjectManager_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "ProjectManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Candidate_ProviderOrganization_ProviderOrganizationId",
                        column: x => x.ProviderOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Candidate_Recruiter_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccount",
                columns: table => new
                {
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentTermId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    AccountManagerDeactivationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    AgencyOwnerDeactivationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AutoApproveTimeEntries = table.Column<bool>(type: "bit", nullable: false),
                    BuyerNumber = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerDeactivationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsCorporate = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "case when [AccountManagerOrganizationId]=[CustomerOrganizationId] AND [AccountManagerId]=[CustomerId] then cast(1 as bit) else cast(0 as bit) end"),
                    IsDeactivated = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "case when (coalesce([AgencyOwnerDeactivationDate],[AccountManagerDeactivationDate],[CustomerDeactivationDate]) is null) then cast(0 as bit) else cast(1 as bit) end"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "case when [AccountManagerOrganizationId]=[CustomerOrganizationId] then cast(1 as bit) else cast(0 as bit) end"),
                    MarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    StripeCustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccount", x => new { x.CustomerOrganizationId, x.CustomerId, x.AccountManagerOrganizationId, x.AccountManagerId });
                    table.ForeignKey(
                        name: "FK_CustomerAccount_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerAccount_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerAccount_OrganizationAccountManager_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_CustomerAccount_OrganizationCustomer_CustomerOrganizationId_CustomerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId },
                        principalTable: "OrganizationCustomer",
                        principalColumns: new[] { "OrganizationId", "CustomerId" });
                    table.ForeignKey(
                        name: "FK_CustomerAccount_Organization_CustomerOrganizationId",
                        column: x => x.CustomerOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerAccount_PaymentTerm_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalTable: "PaymentTerm",
                        principalColumn: "PaymentTermId");
                    table.ForeignKey(
                        name: "FK_CustomerAccount_ProviderOrganization_AccountManagerOrganizationId",
                        column: x => x.AccountManagerOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MarketerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CallbackDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsContacted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "case when [MarketerOrganizationId]=[ProviderOrganizationId] then cast(1 as bit) else cast(0 as bit) end"),
                    Iso2 = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MarketerBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MeetingNotes = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    OrganizationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProvinceState = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    ReferralCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lead_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lead_Marketer_MarketerId",
                        column: x => x.MarketerId,
                        principalTable: "Marketer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lead_OrganizationAccountManager_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_Lead_OrganizationMarketer_MarketerOrganizationId_MarketerId",
                        columns: x => new { x.MarketerOrganizationId, x.MarketerId },
                        principalTable: "OrganizationMarketer",
                        principalColumns: new[] { "OrganizationId", "MarketerId" });
                    table.ForeignKey(
                        name: "FK_Lead_Organization_MarketerOrganizationId",
                        column: x => x.MarketerOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lead_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lead_ProviderOrganization_ProviderOrganizationId",
                        column: x => x.ProviderOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarketingAgreement",
                columns: table => new
                {
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketingOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitiatedByProvider = table.Column<bool>(type: "bit", nullable: false),
                    MarketerBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketerInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[MarketerBonus]+[MarketingAgencyBonus]"),
                    MarketingStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[MarketingAgencyStream]+[MarketerStream]"),
                    RequireUniqueEmail = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingAgreement", x => new { x.ProviderOrganizationId, x.MarketingOrganizationId });
                    table.ForeignKey(
                        name: "FK_MarketingAgreement_MarketingOrganization_MarketingOrganizationId",
                        column: x => x.MarketingOrganizationId,
                        principalTable: "MarketingOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MarketingAgreement_ProviderOrganization_ProviderOrganizationId",
                        column: x => x.ProviderOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationSkill",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationSkill", x => new { x.OrganizationId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_OrganizationSkill_ProviderOrganization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecruitingAgreement",
                columns: table => new
                {
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruitingOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitiatedByProvider = table.Column<bool>(type: "bit", nullable: false),
                    RecruiterBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruiterInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingAgencyBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[RecruitingAgencyBonus]+[RecruiterBonus]"),
                    RecruitingStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[RecruitingAgencyStream]+[RecruiterStream]"),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitingAgreement", x => new { x.ProviderOrganizationId, x.RecruitingOrganizationId });
                    table.ForeignKey(
                        name: "FK_RecruitingAgreement_ProviderOrganization_ProviderOrganizationId",
                        column: x => x.ProviderOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RecruitingAgreement_RecruitingOrganization_RecruitingOrganizationId",
                        column: x => x.RecruitingOrganizationId,
                        principalTable: "RecruitingOrganization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CandidateNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateNotification_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AutoApproveTimeEntries = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Project_CustomerAccount_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId, x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "CustomerAccount",
                        principalColumns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_Project_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Project_OrganizationAccountManager_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_Project_OrganizationCustomer_CustomerOrganizationId_CustomerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId },
                        principalTable: "OrganizationCustomer",
                        principalColumns: new[] { "OrganizationId", "CustomerId" });
                    table.ForeignKey(
                        name: "FK_Project_OrganizationProjectManager_ProjectManagerOrganizationId_ProjectManagerId",
                        columns: x => new { x.ProjectManagerOrganizationId, x.ProjectManagerId },
                        principalTable: "OrganizationProjectManager",
                        principalColumns: new[] { "OrganizationId", "ProjectManagerId" });
                    table.ForeignKey(
                        name: "FK_Project_Organization_BuyerOrganizationId",
                        column: x => x.BuyerOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Project_ProjectManager_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "ProjectManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Project_ProviderOrganization_ProjectManagerOrganizationId",
                        column: x => x.ProjectManagerOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceAgreement",
                columns: table => new
                {
                    DocumentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAgreement", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_ServiceAgreement_CustomerAccount_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId, x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "CustomerAccount",
                        principalColumns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProviderNumber = table.Column<int>(type: "int", nullable: false),
                    ProviderResponseTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrder_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkOrder_CustomerAccount_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId, x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "CustomerAccount",
                        principalColumns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_WorkOrder_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkOrder_OrganizationAccountManager_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_WorkOrder_Organization_BuyerOrganizationId",
                        column: x => x.BuyerOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkOrder_ProviderOrganization_AccountManagerOrganizationId",
                        column: x => x.AccountManagerOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IndividualBonusIntent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BonusType = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualBonusIntent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualBonusIntent_BonusTransfer_TransferId",
                        column: x => x.TransferId,
                        principalTable: "BonusTransfer",
                        principalColumn: "TransferId");
                    table.ForeignKey(
                        name: "FK_IndividualBonusIntent_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndividualBonusIntent_Lead_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndividualBonusIntent_OrganizationPerson_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_IndividualBonusIntent_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeadNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadNotification_Lead_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationBonusIntent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BonusType = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationBonusIntent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationBonusIntent_BonusTransfer_TransferId",
                        column: x => x.TransferId,
                        principalTable: "BonusTransfer",
                        principalColumn: "TransferId");
                    table.ForeignKey(
                        name: "FK_OrganizationBonusIntent_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationBonusIntent_Lead_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationBonusIntent_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerEndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AccountManagerPauseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AccountManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AgencyOwnerEndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AgencyOwnerPauseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyerNumber = table.Column<int>(type: "int", nullable: false),
                    ContractorEndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ContractorPauseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ContractorStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerEndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CustomerPauseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CustomerRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[ContractorStream]+[RecruiterStream]+[ProjectManagerStream]+[AccountManagerStream]+[MarketerStream]+[AgencyStream]+[MarketingAgencyStream]+[RecruitingAgencyStream]+[SystemStream]"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnded = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "case when (coalesce([AgencyOwnerEndDate],[AccountManagerEndDate],[ContractorEndDate],[CustomerEndDate]) is null) then cast(0 as bit) else cast(1 as bit) end"),
                    IsPaused = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "case when (coalesce([AgencyOwnerPauseDate],[AccountManagerPauseDate],[ContractorPauseDate],[CustomerPauseDate]) is null) then cast(0 as bit) else cast(1 as bit) end"),
                    MarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketingNumber = table.Column<int>(type: "int", nullable: false),
                    MaxAccountManagerWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([AccountManagerStream]*[MaxWeeklyHours])"),
                    MaxAgencyWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([AgencyStream]*[MaxWeeklyHours])"),
                    MaxContractorWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([ContractorStream]*[MaxWeeklyHours])"),
                    MaxCustomerWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([ContractorStream]+[RecruiterStream]+[ProjectManagerStream]+[AccountManagerStream]+[MarketerStream]+[AgencyStream]+[MarketingAgencyStream]+[RecruitingAgencyStream]+[SystemStream])*[MaxWeeklyHours]"),
                    MaxMarketerWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([MarketerStream]*[MaxWeeklyHours])"),
                    MaxMarketingAgencyWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([MarketingAgencyStream]*[MaxWeeklyHours])"),
                    MaxProjectManagerWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([ProjectManagerStream]*[MaxWeeklyHours])"),
                    MaxRecruiterWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([RecruiterStream]*[MaxWeeklyHours])"),
                    MaxRecruitingAgencyWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([RecruitingAgencyStream]*[MaxWeeklyHours])"),
                    MaxSystemWeekly = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([SystemStream]*[MaxWeeklyHours])"),
                    MaxWeeklyHours = table.Column<int>(type: "int", nullable: false),
                    ProjectManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProviderNumber = table.Column<int>(type: "int", nullable: false),
                    RecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecruitingNumber = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    SystemStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalHoursLogged = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Contractor_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_CustomerAccount_BuyerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.BuyerOrganizationId, x.CustomerId, x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "CustomerAccount",
                        principalColumns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_Contract_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Marketer_MarketerId",
                        column: x => x.MarketerId,
                        principalTable: "Marketer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_MarketingOrganization_MarketerOrganizationId",
                        column: x => x.MarketerOrganizationId,
                        principalTable: "MarketingOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_OrganizationAccountManager_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_Contract_OrganizationContractor_ContractorOrganizationId_ContractorId",
                        columns: x => new { x.ContractorOrganizationId, x.ContractorId },
                        principalTable: "OrganizationContractor",
                        principalColumns: new[] { "OrganizationId", "ContractorId" });
                    table.ForeignKey(
                        name: "FK_Contract_OrganizationCustomer_BuyerOrganizationId_CustomerId",
                        columns: x => new { x.BuyerOrganizationId, x.CustomerId },
                        principalTable: "OrganizationCustomer",
                        principalColumns: new[] { "OrganizationId", "CustomerId" });
                    table.ForeignKey(
                        name: "FK_Contract_OrganizationMarketer_MarketerOrganizationId_MarketerId",
                        columns: x => new { x.MarketerOrganizationId, x.MarketerId },
                        principalTable: "OrganizationMarketer",
                        principalColumns: new[] { "OrganizationId", "MarketerId" });
                    table.ForeignKey(
                        name: "FK_Contract_OrganizationProjectManager_ProjectManagerOrganizationId_ProjectManagerId",
                        columns: x => new { x.ProjectManagerOrganizationId, x.ProjectManagerId },
                        principalTable: "OrganizationProjectManager",
                        principalColumns: new[] { "OrganizationId", "ProjectManagerId" });
                    table.ForeignKey(
                        name: "FK_Contract_OrganizationRecruiter_RecruiterOrganizationId_RecruiterId",
                        columns: x => new { x.RecruiterOrganizationId, x.RecruiterId },
                        principalTable: "OrganizationRecruiter",
                        principalColumns: new[] { "OrganizationId", "RecruiterId" });
                    table.ForeignKey(
                        name: "FK_Contract_Organization_BuyerOrganizationId",
                        column: x => x.BuyerOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_ProjectManager_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "ProjectManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_ProviderOrganization_ProviderOrganizationId",
                        column: x => x.ProviderOrganizationId,
                        principalTable: "ProviderOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Recruiter_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_RecruitingOrganization_RecruiterOrganizationId",
                        column: x => x.RecruiterOrganizationId,
                        principalTable: "RecruitingOrganization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectBillingCategory",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillingCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBillingCategory", x => new { x.ProjectId, x.BillingCategoryId });
                    table.ForeignKey(
                        name: "FK_ProjectBillingCategory_BillingCategory_BillingCategoryId",
                        column: x => x.BillingCategoryId,
                        principalTable: "BillingCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectBillingCategory_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectInvoice",
                columns: table => new
                {
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectInvoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_CustomerAccount_BuyerOrganizationId_CustomerId_ProviderOrganizationId_AccountManagerId",
                        columns: x => new { x.BuyerOrganizationId, x.CustomerId, x.ProviderOrganizationId, x.AccountManagerId },
                        principalTable: "CustomerAccount",
                        principalColumns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_OrganizationAccountManager_ProviderOrganizationId_AccountManagerId",
                        columns: x => new { x.ProviderOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_OrganizationCustomer_BuyerOrganizationId_CustomerId",
                        columns: x => new { x.BuyerOrganizationId, x.CustomerId },
                        principalTable: "OrganizationCustomer",
                        principalColumns: new[] { "OrganizationId", "CustomerId" });
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_OrganizationProjectManager_ProviderOrganizationId_ProjectManagerId",
                        columns: x => new { x.ProviderOrganizationId, x.ProjectManagerId },
                        principalTable: "OrganizationProjectManager",
                        principalColumns: new[] { "OrganizationId", "ProjectManagerId" });
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_Organization_BuyerOrganizationId",
                        column: x => x.BuyerOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_Organization_ProviderOrganizationId",
                        column: x => x.ProviderOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_ProjectManager_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "ProjectManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectInvoice_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectNotification_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectRetainerIntent",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TopOffAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRetainerIntent", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_CustomerAccount_CustomerOrganizationId_CustomerId_ProviderOrganizationId_AccountManagerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId, x.ProviderOrganizationId, x.AccountManagerId },
                        principalTable: "CustomerAccount",
                        principalColumns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_OrganizationAccountManager_ProviderOrganizationId_AccountManagerId",
                        columns: x => new { x.ProviderOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_OrganizationCustomer_CustomerOrganizationId_CustomerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId },
                        principalTable: "OrganizationCustomer",
                        principalColumns: new[] { "OrganizationId", "CustomerId" });
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_Organization_CustomerOrganizationId",
                        column: x => x.CustomerOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_Organization_ProviderOrganizationId",
                        column: x => x.ProviderOrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectRetainerIntent_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Proposal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgreementText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BudgetBasis = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerRateBasis = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "(([WeeklyMaxHourBasis] * [VelocityBasis]) / 7)"),
                    EstimationBasis = table.Column<int>(type: "int", nullable: false),
                    ExtraDayBasis = table.Column<int>(type: "int", nullable: false),
                    OtherPercentBasis = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    ProposalType = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    RetainerPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StoryHours = table.Column<int>(type: "int", nullable: false, computedColumnSql: "([StoryPointBasis]*[EstimationBasis])"),
                    StoryPointBasis = table.Column<int>(type: "int", nullable: false),
                    TotalDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "(((([StoryPointBasis]*[EstimationBasis]) * (1 + [OtherPercentBasis]))/(([WeeklyMaxHourBasis] * [VelocityBasis]) / 7))+[ExtraDayBasis])"),
                    TotalHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "(([StoryPointBasis]*[EstimationBasis]) * (1 + [OtherPercentBasis]))"),
                    TotalPriceQuoted = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "((([StoryPointBasis]*[EstimationBasis]) * (1 + [OtherPercentBasis])) * [CustomerRateBasis])"),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VelocityBasis = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 1m),
                    WeeklyCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([WeeklyMaxHourBasis] * [VelocityBasis])"),
                    WeeklyMaxHourBasis = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proposal_Project_Id",
                        column: x => x.Id,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractorOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssignedDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CustomerAcceptanceDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CustomerApprovedHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    DueDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProjectManagerAcceptanceDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StoryId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryPoints = table.Column<int>(type: "int", nullable: true),
                    StoryTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TotalHoursLogged = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Story_Contractor_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Story_OrganizationContractor_ContractorOrganizationId_ContractorId",
                        columns: x => new { x.ContractorOrganizationId, x.ContractorId },
                        principalTable: "OrganizationContractor",
                        principalColumns: new[] { "OrganizationId", "ContractorId" });
                    table.ForeignKey(
                        name: "FK_Story_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkOrderNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrderNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrderNotification_WorkOrder_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrder",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractNotification_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeInvoiceItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeInvoiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeInvoiceItem_BuyerAccount_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StripeInvoiceItem_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StripeInvoiceItem_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectInvoiceAdditionalExpense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectInvoiceAdditionalExpense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectInvoiceAdditionalExpense_ProjectInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "ProjectInvoice",
                        principalColumn: "InvoiceId");
                });

            migrationBuilder.CreateTable(
                name: "StripeCharge",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DestinationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Captured = table.Column<bool>(type: "bit", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disputed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OnBehalfOfId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutcomeNetworkStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutcomeReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutcomeRiskLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutcomeRiskScore = table.Column<long>(type: "bigint", nullable: false),
                    OutcomeSellerMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutcomeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    ReceiptEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refunded = table.Column<bool>(type: "bit", nullable: false),
                    StatementDescriptor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatementDescriptorSuffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeCharge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeCharge_BuyerAccount_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "BuyerAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StripeCharge_FinancialAccount_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "FinancialAccount",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_StripeCharge_ProjectRetainerIntent_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectRetainerIntent",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_StripeCharge_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StripeCharge_StripePaymentIntent_PaymentIntentId",
                        column: x => x.PaymentIntentId,
                        principalTable: "StripePaymentIntent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProposalAcceptance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcceptedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcceptedCompletionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AgreementText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetTerms = table.Column<int>(type: "int", nullable: false),
                    ProposalBlob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProposalType = table.Column<int>(type: "int", nullable: false),
                    RetainerAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Velocity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalAcceptance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProposalAcceptance_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProposalAcceptance_OrganizationCustomer_CustomerOrganizationId_CustomerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId },
                        principalTable: "OrganizationCustomer",
                        principalColumns: new[] { "OrganizationId", "CustomerId" });
                    table.ForeignKey(
                        name: "FK_ProposalAcceptance_Proposal_Id",
                        column: x => x.Id,
                        principalTable: "Proposal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProposalNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProposalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProposalNotification_Proposal_ProposalId",
                        column: x => x.ProposalId,
                        principalTable: "Proposal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProposalWorkOrder",
                columns: table => new
                {
                    WorkOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProposalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalWorkOrder", x => new { x.WorkOrderId, x.ProposalId });
                    table.ForeignKey(
                        name: "FK_ProposalWorkOrder_Proposal_ProposalId",
                        column: x => x.ProposalId,
                        principalTable: "Proposal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProposalWorkOrder_WorkOrder_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrder",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountManagerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Internal = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_CustomerAccount_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId, x.AccountManagerOrganizationId, x.AccountManagerId },
                        principalTable: "CustomerAccount",
                        principalColumns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_Comment_Lead_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_OrganizationPerson_OrganizationId_CreatedById",
                        columns: x => new { x.OrganizationId, x.CreatedById },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_Comment_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoryNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoryNotification_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IndividualPayoutIntent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InvoiceItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceTransferId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualPayoutIntent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualPayoutIntent_InvoiceTransfer_InvoiceTransferId",
                        column: x => x.InvoiceTransferId,
                        principalTable: "InvoiceTransfer",
                        principalColumn: "TransferId");
                    table.ForeignKey(
                        name: "FK_IndividualPayoutIntent_OrganizationPerson_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "OrganizationPerson",
                        principalColumns: new[] { "OrganizationId", "PersonId" });
                    table.ForeignKey(
                        name: "FK_IndividualPayoutIntent_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndividualPayoutIntent_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndividualPayoutIntent_StripeInvoiceItem_InvoiceItemId",
                        column: x => x.InvoiceItemId,
                        principalTable: "StripeInvoiceItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndividualPayoutIntent_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationPayoutIntent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InvoiceItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceTransferId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgencyOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationPayoutIntent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationPayoutIntent_InvoiceTransfer_InvoiceTransferId",
                        column: x => x.InvoiceTransferId,
                        principalTable: "InvoiceTransfer",
                        principalColumn: "TransferId");
                    table.ForeignKey(
                        name: "FK_OrganizationPayoutIntent_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationPayoutIntent_StripeInvoiceItem_InvoiceItemId",
                        column: x => x.InvoiceItemId,
                        principalTable: "StripeInvoiceItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrganizationPayoutIntent_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StripeInvoiceLine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceItemId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discountable = table.Column<bool>(type: "bit", nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StripeInvoiceLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StripeInvoiceLine_StripeInvoiceItem_InvoiceItemId",
                        column: x => x.InvoiceItemId,
                        principalTable: "StripeInvoiceItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StripeInvoiceLine_StripeInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StripeInvoice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TimeEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarketerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketingAgencyOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketingOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderAgencyOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruitingAgencyOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruitingOrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TimeType = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    InstantAccountManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantContractorStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantMarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantMarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantProjectManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantRecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantRecruitingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstantSystemStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAccountManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantAccountManagerStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantAgencyStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalContractorStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantContractorStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalCustomerAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([InstantSystemStream]+[InstantAccountManagerStream]+[InstantProjectManagerStream]+[InstantMarketerStream]+[InstantRecruiterStream]+[InstantContractorStream]+[InstantAgencyStream]+[InstantRecruitingAgencyStream]+[InstantMarketingAgencyStream])*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalMarketerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantMarketerStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalMarketingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantMarketingAgencyStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalMarketingStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([InstantMarketingAgencyStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0))+([InstantMarketerStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0))"),
                    TotalMinutes = table.Column<int>(type: "int", nullable: false, computedColumnSql: "DATEDIFF(minute, [StartDate], [EndDate])"),
                    TotalProjectManagerStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantProjectManagerStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalRecruiterStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantRecruiterStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalRecruitingAgencyStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantRecruitingAgencyStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    TotalRecruitingStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "([InstantRecruitingAgencyStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0))+([InstantRecruiterStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0))"),
                    TotalSystemStream = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[InstantSystemStream]*(DATEDIFF(second, [StartDate], [EndDate]) / 3600.0)"),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeEntry_AccountManager_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "AccountManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_BillingCategory_TimeType",
                        column: x => x.TimeType,
                        principalTable: "BillingCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Contractor_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Customer_MarketingAgencyOwnerId",
                        column: x => x.MarketingAgencyOwnerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Customer_ProviderAgencyOwnerId",
                        column: x => x.ProviderAgencyOwnerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Customer_RecruitingAgencyOwnerId",
                        column: x => x.RecruitingAgencyOwnerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Marketer_MarketerId",
                        column: x => x.MarketerId,
                        principalTable: "Marketer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_OrganizationAccountManager_ProviderOrganizationId_AccountManagerId",
                        columns: x => new { x.ProviderOrganizationId, x.AccountManagerId },
                        principalTable: "OrganizationAccountManager",
                        principalColumns: new[] { "OrganizationId", "AccountManagerId" });
                    table.ForeignKey(
                        name: "FK_TimeEntry_OrganizationContractor_ProviderOrganizationId_ContractorId",
                        columns: x => new { x.ProviderOrganizationId, x.ContractorId },
                        principalTable: "OrganizationContractor",
                        principalColumns: new[] { "OrganizationId", "ContractorId" });
                    table.ForeignKey(
                        name: "FK_TimeEntry_OrganizationCustomer_CustomerOrganizationId_CustomerId",
                        columns: x => new { x.CustomerOrganizationId, x.CustomerId },
                        principalTable: "OrganizationCustomer",
                        principalColumns: new[] { "OrganizationId", "CustomerId" });
                    table.ForeignKey(
                        name: "FK_TimeEntry_OrganizationMarketer_MarketingOrganizationId_MarketerId",
                        columns: x => new { x.MarketingOrganizationId, x.MarketerId },
                        principalTable: "OrganizationMarketer",
                        principalColumns: new[] { "OrganizationId", "MarketerId" });
                    table.ForeignKey(
                        name: "FK_TimeEntry_OrganizationProjectManager_ProviderOrganizationId_ProjectManagerId",
                        columns: x => new { x.ProviderOrganizationId, x.ProjectManagerId },
                        principalTable: "OrganizationProjectManager",
                        principalColumns: new[] { "OrganizationId", "ProjectManagerId" });
                    table.ForeignKey(
                        name: "FK_TimeEntry_OrganizationRecruiter_RecruitingOrganizationId_RecruiterId",
                        columns: x => new { x.RecruitingOrganizationId, x.RecruiterId },
                        principalTable: "OrganizationRecruiter",
                        principalColumns: new[] { "OrganizationId", "RecruiterId" });
                    table.ForeignKey(
                        name: "FK_TimeEntry_ProjectManager_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "ProjectManager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Recruiter_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntry_StripeInvoiceItem_InvoiceItemId",
                        column: x => x.InvoiceItemId,
                        principalTable: "StripeInvoiceItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TimeEntryNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeEntryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acknowledged = table.Column<bool>(type: "bit", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiresAcknowledgement = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeEntryNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeEntryNotification_TimeEntry_TimeEntryId",
                        column: x => x.TimeEntryId,
                        principalTable: "TimeEntry",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_CategoryId",
                table: "Organization",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_CustomerId",
                table: "Organization",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCard_AccountId",
                table: "AccountCard",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_ProjectManagerId",
                table: "Candidate",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_ProjectManagerOrganizationId_ProjectManagerId",
                table: "Candidate",
                columns: new[] { "ProjectManagerOrganizationId", "ProjectManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_ProviderOrganizationId",
                table: "Candidate",
                column: "ProviderOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_RecruiterId",
                table: "Candidate",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_RecruiterOrganizationId_RecruiterId",
                table: "Candidate",
                columns: new[] { "RecruiterOrganizationId", "RecruiterId" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateNotification_CandidateId",
                table: "CandidateNotification",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBillingCategory_BillingCategoryId",
                table: "CategoryBillingCategory",
                column: "BillingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPaymentTerm_PaymentTermId",
                table: "CategoryPaymentTerm",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPosition_PositionId",
                table: "CategoryPosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySkill_CategoryId",
                table: "CategorySkill",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CandidateId",
                table: "Comment",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ContractId",
                table: "Comment",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                table: "Comment",
                columns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_LeadId",
                table: "Comment",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_OrganizationId_CreatedById",
                table: "Comment",
                columns: new[] { "OrganizationId", "CreatedById" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProjectId",
                table: "Comment",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_StoryId",
                table: "Comment",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "ContractMarketingNumberIndex",
                table: "Contract",
                columns: new[] { "MarketerOrganizationId", "MarketingNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ContractProviderNumberIndex",
                table: "Contract",
                columns: new[] { "ContractorOrganizationId", "ProviderNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ContractRecruitingNumberIndex",
                table: "Contract",
                columns: new[] { "RecruiterOrganizationId", "RecruitingNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contract_AccountManagerId",
                table: "Contract",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_AccountManagerOrganizationId_AccountManagerId",
                table: "Contract",
                columns: new[] { "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_BuyerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                table: "Contract",
                columns: new[] { "BuyerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ContractorId",
                table: "Contract",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ContractorOrganizationId_ContractorId",
                table: "Contract",
                columns: new[] { "ContractorOrganizationId", "ContractorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_CustomerId",
                table: "Contract",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_MarketerId",
                table: "Contract",
                column: "MarketerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_MarketerOrganizationId_MarketerId",
                table: "Contract",
                columns: new[] { "MarketerOrganizationId", "MarketerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ProjectId",
                table: "Contract",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ProjectManagerId",
                table: "Contract",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ProjectManagerOrganizationId_ProjectManagerId",
                table: "Contract",
                columns: new[] { "ProjectManagerOrganizationId", "ProjectManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ProviderOrganizationId",
                table: "Contract",
                column: "ProviderOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_RecruiterId",
                table: "Contract",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_RecruiterOrganizationId_RecruiterId",
                table: "Contract",
                columns: new[] { "RecruiterOrganizationId", "RecruiterId" });

            migrationBuilder.CreateIndex(
                name: "IX_ContractNotification_ContractId",
                table: "ContractNotification",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_RecruiterId",
                table: "Contractor",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_RecruiterOrganizationId_RecruiterId",
                table: "Contractor",
                columns: new[] { "RecruiterOrganizationId", "RecruiterId" });

            migrationBuilder.CreateIndex(
                name: "IX_ContractorSkill_ContractorId",
                table: "ContractorSkill",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_MarketerOrganizationId_MarketerId",
                table: "Customer",
                columns: new[] { "MarketerOrganizationId", "MarketerId" });

            migrationBuilder.CreateIndex(
                name: "AccountNumberIndex",
                table: "CustomerAccount",
                columns: new[] { "AccountManagerOrganizationId", "Number" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "BuyerNumberIndex",
                table: "CustomerAccount",
                columns: new[] { "CustomerOrganizationId", "BuyerNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_AccountManagerId",
                table: "CustomerAccount",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_AccountManagerOrganizationId_AccountManagerId",
                table: "CustomerAccount",
                columns: new[] { "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_CustomerId",
                table: "CustomerAccount",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_PaymentTermId",
                table: "CustomerAccount",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_CustomerEntityId",
                table: "CustomerCard",
                column: "CustomerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_CustomerId",
                table: "CustomerCard",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualBonusIntent_CandidateId",
                table: "IndividualBonusIntent",
                column: "CandidateId",
                unique: true,
                filter: "[CandidateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualBonusIntent_LeadId",
                table: "IndividualBonusIntent",
                column: "LeadId",
                unique: true,
                filter: "[LeadId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualBonusIntent_OrganizationId_PersonId",
                table: "IndividualBonusIntent",
                columns: new[] { "OrganizationId", "PersonId" });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualBonusIntent_PersonId",
                table: "IndividualBonusIntent",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualBonusIntent_TransferId",
                table: "IndividualBonusIntent",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualBuyerAccount_BuyerAccountId",
                table: "IndividualBuyerAccount",
                column: "BuyerAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndividualFinancialAccount_FinancialAccountId",
                table: "IndividualFinancialAccount",
                column: "FinancialAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndividualPayoutIntent_InvoiceId",
                table: "IndividualPayoutIntent",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualPayoutIntent_InvoiceItemId",
                table: "IndividualPayoutIntent",
                column: "InvoiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualPayoutIntent_InvoiceTransferId",
                table: "IndividualPayoutIntent",
                column: "InvoiceTransferId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualPayoutIntent_OrganizationId_PersonId",
                table: "IndividualPayoutIntent",
                columns: new[] { "OrganizationId", "PersonId" });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualPayoutIntent_PersonId",
                table: "IndividualPayoutIntent",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTransfer_InvoiceId",
                table: "InvoiceTransfer",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_AccountManagerId",
                table: "Lead",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_AccountManagerOrganizationId_AccountManagerId",
                table: "Lead",
                columns: new[] { "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Lead_MarketerId",
                table: "Lead",
                column: "MarketerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_MarketerOrganizationId_MarketerId",
                table: "Lead",
                columns: new[] { "MarketerOrganizationId", "MarketerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Lead_PersonId",
                table: "Lead",
                column: "PersonId",
                unique: true,
                filter: "[PersonId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_ProviderOrganizationId",
                table: "Lead",
                column: "ProviderOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadNotification_LeadId",
                table: "LeadNotification",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Level_PositionId",
                table: "Level",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAgreement_MarketingOrganizationId",
                table: "MarketingAgreement",
                column: "MarketingOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingOrganization_Id_DefaultMarketerId",
                table: "MarketingOrganization",
                columns: new[] { "Id", "DefaultMarketerId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAccountManager_AccountManagerId",
                table: "OrganizationAccountManager",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationBillingCategory_BillingCategoryId",
                table: "OrganizationBillingCategory",
                column: "BillingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationBonusIntent_CandidateId",
                table: "OrganizationBonusIntent",
                column: "CandidateId",
                unique: true,
                filter: "[CandidateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationBonusIntent_LeadId",
                table: "OrganizationBonusIntent",
                column: "LeadId",
                unique: true,
                filter: "[LeadId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationBonusIntent_OrganizationId",
                table: "OrganizationBonusIntent",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationBonusIntent_TransferId",
                table: "OrganizationBonusIntent",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationBuyerAccount_BuyerAccountId",
                table: "OrganizationBuyerAccount",
                column: "BuyerAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationContractor_ContractorId",
                table: "OrganizationContractor",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationContractor_LevelId",
                table: "OrganizationContractor",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationContractor_PositionId",
                table: "OrganizationContractor",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationCustomer_CustomerId",
                table: "OrganizationCustomer",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationFinancialAccount_FinancialAccountId",
                table: "OrganizationFinancialAccount",
                column: "FinancialAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationMarketer_MarketerId",
                table: "OrganizationMarketer",
                column: "MarketerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationPaymentTerm_PaymentTermId",
                table: "OrganizationPaymentTerm",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationPayoutIntent_InvoiceId",
                table: "OrganizationPayoutIntent",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationPayoutIntent_InvoiceItemId",
                table: "OrganizationPayoutIntent",
                column: "InvoiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationPayoutIntent_InvoiceTransferId",
                table: "OrganizationPayoutIntent",
                column: "InvoiceTransferId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationPayoutIntent_OrganizationId",
                table: "OrganizationPayoutIntent",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationPosition_PositionId",
                table: "OrganizationPosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationProjectManager_ProjectManagerId",
                table: "OrganizationProjectManager",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationRecruiter_RecruiterId",
                table: "OrganizationRecruiter",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationSkill_SkillId",
                table: "OrganizationSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationSubscription_StripeSubscriptionId",
                table: "OrganizationSubscription",
                column: "StripeSubscriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonNotification_PersonId",
                table: "PersonNotification",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_AccountManagerId",
                table: "Project",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_AccountManagerOrganizationId_AccountManagerId",
                table: "Project",
                columns: new[] { "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Project_BuyerOrganizationId",
                table: "Project",
                column: "BuyerOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_CustomerId",
                table: "Project",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                table: "Project",
                columns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectManagerId",
                table: "Project",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectManagerOrganizationId_ProjectManagerId",
                table: "Project",
                columns: new[] { "ProjectManagerOrganizationId", "ProjectManagerId" });

            migrationBuilder.CreateIndex(
                name: "ProjectAbbreviationIndex",
                table: "Project",
                columns: new[] { "AccountManagerOrganizationId", "Abbreviation" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBillingCategory_BillingCategoryId",
                table: "ProjectBillingCategory",
                column: "BillingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoice_AccountManagerId",
                table: "ProjectInvoice",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoice_BuyerOrganizationId_CustomerId_ProviderOrganizationId_AccountManagerId",
                table: "ProjectInvoice",
                columns: new[] { "BuyerOrganizationId", "CustomerId", "ProviderOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoice_CustomerId",
                table: "ProjectInvoice",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoice_ProjectId",
                table: "ProjectInvoice",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoice_ProjectManagerId",
                table: "ProjectInvoice",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoice_ProviderOrganizationId_AccountManagerId",
                table: "ProjectInvoice",
                columns: new[] { "ProviderOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoice_ProviderOrganizationId_ProjectManagerId",
                table: "ProjectInvoice",
                columns: new[] { "ProviderOrganizationId", "ProjectManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInvoiceAdditionalExpense_InvoiceId",
                table: "ProjectInvoiceAdditionalExpense",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNotification_ProjectId",
                table: "ProjectNotification",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRetainerIntent_AccountManagerId",
                table: "ProjectRetainerIntent",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRetainerIntent_CustomerId",
                table: "ProjectRetainerIntent",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRetainerIntent_CustomerOrganizationId_CustomerId_ProviderOrganizationId_AccountManagerId",
                table: "ProjectRetainerIntent",
                columns: new[] { "CustomerOrganizationId", "CustomerId", "ProviderOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRetainerIntent_ProviderOrganizationId_AccountManagerId",
                table: "ProjectRetainerIntent",
                columns: new[] { "ProviderOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProposalAcceptance_CustomerId",
                table: "ProposalAcceptance",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProposalAcceptance_CustomerOrganizationId_CustomerId",
                table: "ProposalAcceptance",
                columns: new[] { "CustomerOrganizationId", "CustomerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProposalNotification_ProposalId",
                table: "ProposalNotification",
                column: "ProposalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProposalWorkOrder_ProposalId",
                table: "ProposalWorkOrder",
                column: "ProposalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderOrganization_Id_DefaultAccountManagerId",
                table: "ProviderOrganization",
                columns: new[] { "Id", "DefaultAccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProviderOrganization_Id_DefaultContractorId",
                table: "ProviderOrganization",
                columns: new[] { "Id", "DefaultContractorId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProviderOrganization_Id_DefaultProjectManagerId",
                table: "ProviderOrganization",
                columns: new[] { "Id", "DefaultProjectManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_RecruitingAgreement_RecruitingOrganizationId",
                table: "RecruitingAgreement",
                column: "RecruitingOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitingOrganization_Id_DefaultRecruiterId",
                table: "RecruitingOrganization",
                columns: new[] { "Id", "DefaultRecruiterId" });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAgreement_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                table: "ServiceAgreement",
                columns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Story_ContractorId",
                table: "Story",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_ContractorOrganizationId_ContractorId",
                table: "Story",
                columns: new[] { "ContractorOrganizationId", "ContractorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Story_ProjectId",
                table: "Story",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryNotification_StoryId",
                table: "StoryNotification",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeBalanceTransaction_PayoutId",
                table: "StripeBalanceTransaction",
                column: "PayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeCharge_CustomerId",
                table: "StripeCharge",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeCharge_DestinationId",
                table: "StripeCharge",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeCharge_InvoiceId",
                table: "StripeCharge",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeCharge_PaymentIntentId",
                table: "StripeCharge",
                column: "PaymentIntentId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeCharge_ProjectId",
                table: "StripeCharge",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeCheckoutSession_CustomerId",
                table: "StripeCheckoutSession",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeInvoice_CustomerId",
                table: "StripeInvoice",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeInvoice_SubscriptionId",
                table: "StripeInvoice",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeInvoiceItem_ContractId",
                table: "StripeInvoiceItem",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeInvoiceItem_CustomerId",
                table: "StripeInvoiceItem",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeInvoiceItem_InvoiceId",
                table: "StripeInvoiceItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeInvoiceLine_InvoiceId",
                table: "StripeInvoiceLine",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeInvoiceLine_InvoiceItemId",
                table: "StripeInvoiceLine",
                column: "InvoiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StripePaymentIntent_InvoiceId",
                table: "StripePaymentIntent",
                column: "InvoiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StripeSource_CustomerId",
                table: "StripeSource",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeSubscriptionItem_SubscriptionId",
                table: "StripeSubscriptionItem",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_StripeTransfer_DestinationId",
                table: "StripeTransfer",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_AccountManagerId",
                table: "TimeEntry",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ContractId",
                table: "TimeEntry",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ContractorId",
                table: "TimeEntry",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_CustomerId",
                table: "TimeEntry",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_CustomerOrganizationId_CustomerId",
                table: "TimeEntry",
                columns: new[] { "CustomerOrganizationId", "CustomerId" });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_InvoiceItemId",
                table: "TimeEntry",
                column: "InvoiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_MarketerId",
                table: "TimeEntry",
                column: "MarketerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_MarketingAgencyOwnerId",
                table: "TimeEntry",
                column: "MarketingAgencyOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_MarketingOrganizationId_MarketerId",
                table: "TimeEntry",
                columns: new[] { "MarketingOrganizationId", "MarketerId" });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProjectId",
                table: "TimeEntry",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProjectManagerId",
                table: "TimeEntry",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProviderAgencyOwnerId",
                table: "TimeEntry",
                column: "ProviderAgencyOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProviderOrganizationId_AccountManagerId",
                table: "TimeEntry",
                columns: new[] { "ProviderOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProviderOrganizationId_ContractorId",
                table: "TimeEntry",
                columns: new[] { "ProviderOrganizationId", "ContractorId" });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProviderOrganizationId_ProjectManagerId",
                table: "TimeEntry",
                columns: new[] { "ProviderOrganizationId", "ProjectManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_RecruiterId",
                table: "TimeEntry",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_RecruitingAgencyOwnerId",
                table: "TimeEntry",
                column: "RecruitingAgencyOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_RecruitingOrganizationId_RecruiterId",
                table: "TimeEntry",
                columns: new[] { "RecruitingOrganizationId", "RecruiterId" });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_StoryId",
                table: "TimeEntry",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_TimeType",
                table: "TimeEntry",
                column: "TimeType");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntryNotification_TimeEntryId",
                table: "TimeEntryNotification",
                column: "TimeEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotification_PersonId",
                table: "UserNotification",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "BuyerNumberIndex",
                table: "WorkOrder",
                columns: new[] { "CustomerOrganizationId", "BuyerNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_AccountManagerId",
                table: "WorkOrder",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_AccountManagerOrganizationId_AccountManagerId",
                table: "WorkOrder",
                columns: new[] { "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_BuyerOrganizationId",
                table: "WorkOrder",
                column: "BuyerOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_CustomerId",
                table: "WorkOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_CustomerOrganizationId_CustomerId_AccountManagerOrganizationId_AccountManagerId",
                table: "WorkOrder",
                columns: new[] { "CustomerOrganizationId", "CustomerId", "AccountManagerOrganizationId", "AccountManagerId" });

            migrationBuilder.CreateIndex(
                name: "ProviderNumberIndex",
                table: "WorkOrder",
                columns: new[] { "AccountManagerOrganizationId", "ProviderNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrderNotification_WorkOrderId",
                table: "WorkOrderNotification",
                column: "WorkOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Category_CategoryId",
                table: "Organization",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Customer_CustomerId",
                table: "Organization",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
