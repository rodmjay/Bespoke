namespace AgencyPro.Shared.Models
{
    public abstract class MarketingAgreementOutput : IMarketingAgreement
    {
        public Guid ProviderOrganizationId { get; set; }
        public Guid MarketingOrganizationId { get; set; }

        public string ProviderOrganizationName { get; set; } = null!;
        public string ProviderOrganizationImageUrl { get; set; } = null!;

        public string MarketingOrganizationName { get; set; } = null!;
        public string MarketingOrganizationImageUrl { get; set; } = null!;
        public AgreementStatus Status { get; set; }
        public virtual bool InitiatedByProvider { get; set; }

        public virtual decimal MarketerBonus { get; set; }
        public virtual decimal MarketingAgencyStream { get; set; }
        public virtual decimal MarketingAgencyBonus { get; set; }
        public virtual decimal MarketerStream { get; set; }

        public virtual decimal MarketingStream
        {
            get => MarketingAgencyStream + MarketerStream;
            set { }
        }

        public virtual decimal MarketingBonus
        {
            get => MarketingAgencyBonus + MarketerBonus;
            set { }
        }

    }
}