﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion


namespace ResumePro.Api.Controllers;

public interface IDegreesController
{
    Task<DegreeDto> GetDegree(int personId, int schoolId, int degreeId);
    Task<List<DegreeDto>> GetDegrees(int personId, int schoolId);

    Task<ActionResult<DegreeDto>> UpdateDegree(int personId, int schoolId,
        int degreeId, DegreeOptions options);

    Task<Result> DeleteDegree(int personId, int schoolId,
        int degreeId);

    Task<ActionResult<DegreeDto>> CreateDegree(int personId, int schoolId, DegreeOptions options);
}