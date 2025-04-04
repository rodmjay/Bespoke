﻿using Bespoke.Shared.Enums;

namespace Bespoke.Core.Settings;

public class AppSettings
{
    public string Name { get; set; }
    public string Version { get; set; }
    public OperationMode Mode { get; set; } = OperationMode.Demo;
}