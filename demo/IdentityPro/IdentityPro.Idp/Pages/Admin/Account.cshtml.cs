using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace IdentityPro.Idp.Pages.Admin
{
    [Authorize(Roles = "Administrator")]
    public class AccountModel : PageModel
    {
        private readonly ILogger<AccountModel> _logger;

        public AccountModel(ILogger<AccountModel> logger)
        {
            _logger = logger;
            // Initialize with sample data
            TotalUsers = 10;
            ActiveUsers = 8;
            LockedAccounts = 1;
            RecentActivities = new List<ActivityLog>
            {
                new ActivityLog { User = "jdoe@example.com", Action = "Login", Date = DateTime.Now.AddHours(-1) },
                new ActivityLog { User = "asmith@example.com", Action = "Password Change", Date = DateTime.Now.AddHours(-3) },
                new ActivityLog { User = "bjones@example.com", Action = "Login Failed", Date = DateTime.Now.AddHours(-5) }
            };
        }

        public int TotalUsers { get; set; }
        public int ActiveUsers { get; set; }
        public int LockedAccounts { get; set; }
        public List<ActivityLog> RecentActivities { get; set; }

        public void OnGet()
        {
            _logger.LogInformation("Admin account page accessed");
            // In a real implementation, you would load actual data from your user repository
        }

        public class ActivityLog
        {
            public string User { get; set; }
            public string Action { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
