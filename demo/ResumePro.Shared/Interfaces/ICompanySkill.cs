﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Shared.Interfaces;

public interface ICompanySkill
{
    int OrganizationId { get; set; }
    int CompanyId { get; set; }
    int PersonId { get; set; }
    int SkillId { get; set; }
}