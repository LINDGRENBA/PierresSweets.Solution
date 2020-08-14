using System.ComponentModel.DataAnnotations;

namespace Bakery.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [FirstName]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [LastName]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The passwords do not match.")]
    public string ConfirmPassword { get; set; }
  }
}