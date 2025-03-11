﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations;

namespace ResumePro.Shared.Options;

public class TemplateOptions
{
    [Required] public string Template { get; set; } = null!;

    [Required] public string Format { get; set; } = null!;

    [Required] public string Engine { get; set; } = null!;

    [Required] public string Name { get; set; } = null!;
}