﻿namespace IdentityPro.Services.Implementation;

public partial class UserService
{
    public Task SetPasswordHashAsync(User user, string passwordHash,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        if (user == null)
            throw new ArgumentNullException(nameof(user));

        user.PasswordHash = passwordHash;
        return Task.CompletedTask;
    }

    public Task<string?> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        if (user == null) throw new ArgumentNullException(nameof(user));

        return Task.FromResult(user.PasswordHash);
    }

    public Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();

        return Task.FromResult(!string.IsNullOrWhiteSpace(user.PasswordHash));
    }
}