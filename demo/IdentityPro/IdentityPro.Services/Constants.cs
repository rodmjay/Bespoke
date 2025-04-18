﻿using Microsoft.AspNetCore.Identity;

namespace IdentityPro.Services;

public static class Constants
{
    public static class LocalIdentity
    {
        public static string DefaultApplicationScheme = IdentityConstants.ApplicationScheme;
        public static string DefaultExternalScheme = IdentityConstants.ExternalScheme;

        public static bool AllowLocalLogin = true;
        public static bool AllowRememberLogin = true;
        public static TimeSpan RememberMeLoginDuration = TimeSpan.FromDays(30);

        public static bool ShowLogoutPrompt = true;
        public static bool AutomaticRedirectAfterSignOut = false;

        public static string InvalidCredentialsErrorMessage = "Invalid username or password";
    }
}