using System.ComponentModel.DataAnnotations;

namespace WeBoozin.Models
{
    public class UserUpdate
    {
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Name cannot be more than 35 characters.")]
        [Display(Name = "Your name.")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Name must start from upper case and contain only letters.")]
        public string Name { get; set; }


        [StringLength(35, MinimumLength = 1, ErrorMessage = "Surname cannot be more than 35 characters.")]
        [Display(Name = "Your surname.")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Surname must start from upper case and contain only letters.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(35, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 35 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,35}$", ErrorMessage = "Password must contain at least one uppercase letter, " +
                "one lowercase letter, one number, and one special character.")]
        [Display(Name = "Your password.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [DataType(DataType.Password)]
        [StringLength(35, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 35 characters.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Telephone is required.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Your telephone number.")]
        [RegularExpression(@"^\+?(\d{1,3})?[-. ]?\d{1,4}[-. ]?\d{1,4}[-. ]?\d{1,9}$", ErrorMessage = "The number can start with + and optionally contain the country code " +
            "and a separator, and then the main part of the number")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 50 characters.")]
        [Display(Name = "Your address.")]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9\s,.'-]{5,50}$", ErrorMessage = "Address must start from upper case and contain only letters, numbers, and special characters" +
            "and be from 5 to 50 characters long.")]
        public string Address { get; set; }
    }
}
