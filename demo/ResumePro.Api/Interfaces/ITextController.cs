#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Api.Interfaces;

public interface ITextController
{
    Task<ChatResult> Professionalize([FromBody] ChatOptions options);
}