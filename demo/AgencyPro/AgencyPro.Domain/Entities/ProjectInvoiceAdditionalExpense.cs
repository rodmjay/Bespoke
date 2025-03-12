namespace AgencyPro.Domain.Entities;

public class ProjectInvoiceAdditionalExpense : BaseEntity<ProjectInvoiceAdditionalExpense>
{
    public int Id { get; set; }

    public string InvoiceId { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Amount { get; set; }

    public ProjectInvoice ProjectInvoice { get; set; }

    public override void Configure(EntityTypeBuilder<ProjectInvoiceAdditionalExpense> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.ProjectInvoice)
            .WithMany(x => x.AdditionalExpenses)
            .HasForeignKey(x => x.InvoiceId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}