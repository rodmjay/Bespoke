namespace AgencyPro.Domain.Entities;

public class Skill : BaseEntity<Skill>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string IconUrl { get; set; } = null!;
    public int Priority { get; set; }

    public ICollection<OrganizationSkill> OrganizationSkill { get; set; }
    public ICollection<CategorySkill> SkillCategories { get; set; }
    public ICollection<ContractorSkill> ContractorSkills { get; set; }

    public override void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder.HasKey(x => x.Id);
    }
}