#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Shared.Options;

public class TextResumeOptions
{
    public string Description { get; set; } = null!;

    public List<TextHighlightOptions> Highlights { get; set; } = new List<TextHighlightOptions>();
}