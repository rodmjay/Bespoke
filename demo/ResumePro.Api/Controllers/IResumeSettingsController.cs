#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Api.Controllers;

public interface IResumeSettingsController
{

    Task<ActionResult<ResumeSettingsDto>> UpdateSettings(
        int personId, int resumeId,
        ResumeSettingsOptions options);
}