using System.ComponentModel.DataAnnotations;

namespace IdentityPro.Idp.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
