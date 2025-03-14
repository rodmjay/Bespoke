using Microsoft.AspNetCore.Authorization;

namespace IdentityPro.Idp.Pages.Account
{
    [AllowAnonymous]
    public class LockoutModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
