namespace AgencyPro.Domain.Entities
{
    public class ContractStatusTransition : BaseEntity<ContractStatusTransition>
    {
        public int Id { get; set; }
        public Guid ContractId { get; set; }
        public ContractStatus Status { get; set; }
        public override void Configure(EntityTypeBuilder<ContractStatusTransition> builder)
        {
            //throw new NotImplementedException();
        }
        public DateTimeOffset Created { get; set; }

    }
}