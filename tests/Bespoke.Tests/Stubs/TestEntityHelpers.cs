#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Bespoke.Data.Enums;

namespace Bespoke.Tests.Stubs;

public class TestEntityHelpers
{
    public static IEnumerable<TestEntity> ValidEntities =>
        new List<TestEntity>
        {
            new TestEntity {Id = 1, Name = "test1", ObjectState = ObjectState.Added},
            new TestEntity {Id = 2, Name = "test2", ObjectState = ObjectState.Added},
        };
}