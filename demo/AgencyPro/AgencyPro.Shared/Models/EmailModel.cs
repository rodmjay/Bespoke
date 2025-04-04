using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Shared.Models;

public class EmailModel
{
    [Required] [EmailAddress] public string Email { get; set; }
}