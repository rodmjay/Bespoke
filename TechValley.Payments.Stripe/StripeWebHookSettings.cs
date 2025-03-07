#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace TechValley.Payments.Stripe;

public class StripeWebHookSettings
{
    public string EndpointUrl { get; set; } = "";
    public List<string> Events { get; set; } = new();
}