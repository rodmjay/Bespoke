#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Shared.Filters;

public class PersonaFilters
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public List<int> Skills { get; set; } = new();
    public List<int> States { get; set; } = new();
}