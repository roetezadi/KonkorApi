using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KonkorApi.Models
{
    // Models returned by AccountController actions.


    public class UserModel
    {
        [Required]
        [Display(Name = @"User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = @"The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = @"Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = @"Confirm password")]
        [Compare("Password", ErrorMessage = @"The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Discriminator { get; set; }

    }
    public class ExternalLoginViewModel
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string State { get; set; }
    }

    public class ManageInfoViewModel
    {
        public string LocalLoginProvider { get; set; }

        public string Email { get; set; }

        public IEnumerable<UserLoginInfoViewModel> Logins { get; set; }

        public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
    }

    public class UserInfoViewModel
    {
        public string Email { get; set; }

        public bool HasRegistered { get; set; }

        public string LoginProvider { get; set; }
    }

    public class UserLoginInfoViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }
}
