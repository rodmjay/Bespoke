using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Options
{
    public class OrganizationMarketerInput : IOrganizationMarketer
    {
        [Required] public virtual decimal MarketerStream { get; set; }
        public virtual decimal MarketerBonus { get; set; }
        public virtual Guid MarketerId { get; set; }
        public virtual Guid OrganizationId { get; set; }
    }
}