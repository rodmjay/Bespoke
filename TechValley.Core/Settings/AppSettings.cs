#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace TechValley.Core.Settings;

public class AppSettings
{
    public string ApiUrl { get; set; }
    public string AppUrl { get; set; }
    public string ResumeApiUrl { get; set; }
  
    public string Name { get; set; }
    public string CodeSigningThumbprint { get; set; }
    
    public bool UseAuthentication { get; set; }
}