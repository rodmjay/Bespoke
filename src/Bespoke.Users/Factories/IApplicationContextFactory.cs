#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore.Design;
using Bespoke.Users.Contexts;

namespace Bespoke.Users.Factories;

public interface IApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
}