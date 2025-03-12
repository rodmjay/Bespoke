namespace AgencyPro.Shared.Models;

public class ContractorSkillOutput
{
    public virtual Guid Id { get; set; }
    public virtual string Name { get; set; } = null!;

    public virtual int Priority { get; set; }
}