#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Api.Controllers;

public interface ISchoolsController
{
    Task<List<SchoolDetails>> GetSchools(int personId);
    Task<SchoolDetails> GetSchool(int personId, int schoolId);

    Task<ActionResult<SchoolDetails>> UpdateSchool(int personId,
        int schoolId,
        SchoolOptions options);

    Task<Result> DeleteSchool(int personId,
        int schoolId);

    Task<ActionResult<SchoolDetails>> CreateSchool(int personId,
        SchoolOptions options);
}