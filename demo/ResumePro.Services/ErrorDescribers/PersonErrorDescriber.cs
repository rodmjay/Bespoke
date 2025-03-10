﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace ResumePro.Services.ErrorDescribers;

public class PersonErrorDescriber
{
    public virtual Error PersonNotFound(int personId)
    {
        return new Error
        {
            Code = nameof(PersonNotFound),
            Description = null
        };
    }

    public virtual Error UnableToSavePerson()
    {
        return new Error
        {
            Code = nameof(UnableToSavePerson),
            Description = null
        };
    }
}