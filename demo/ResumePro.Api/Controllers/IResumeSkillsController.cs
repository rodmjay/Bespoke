
namespace ResumePro.Api.Controllers;

public interface IResumeSkillsController
{
    Task<Result> AddResumeSkill(int personId, int resumeId,
        int skillId);

    Task<Result> DeleteResumeSkill(int personId, int resumeId,
        int skillId);
}