#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Api.Interfaces;

public interface IReferencesController
{
    Task<ReferenceDto> Get(int personId, int referenceId);
    Task<List<ReferenceDto>> GetReferences(int personId);

    Task<ActionResult<ReferenceDto>> CreateReference(int personId,
        ReferenceOptions options);

    Task<ActionResult<ReferenceDto>> UpdateReference(int personId,
        int referenceId,
        ReferenceOptions options);

    Task<Result> DeleteReference(int personId,
        int referenceId);
}