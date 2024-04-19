using System.ComponentModel.DataAnnotations;

namespace WeBoozin.Models
{
    public class NewUser
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "Name cannot be more than 35 characters.")]
        [Display(Name = "Your name.")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Name must start from upper case and contain only letters.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Surname is required.")]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "Surname cannot be more than 35 characters.")]
        [Display(Name = "Your surname.")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Surname must start from upper case and contain only letters.")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Username is required.")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 35 characters.")]
        [Display(Name = "Your username.")]
        [RegularExpression(@"^[a-zA-Z]\w*$", ErrorMessage = "Username can only contain letters, numbers, and underscores.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Your email.")]
        [StringLength(45, MinimumLength = 5, ErrorMessage = "Email must be between 5 and 45 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(35, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 35 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&\._])[A-Za-z\d@$!%*?&\._]{8,35}$", ErrorMessage = "Password must contain at least one uppercase letter, " +
        "one lowercase letter, one number, and one special character (including . and _ ).")]
        [Display(Name = "Your password.")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm password is required.")]
        [DataType(DataType.Password)]
        [StringLength(35, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 35 characters.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Telephone is required.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Your telephone number.")]
        [RegularExpression(@"^\+?(\d{1,3})?[-. ]?\d{1,4}[-. ]?\d{1,4}[-. ]?\d{1,9}$", ErrorMessage = "The number can start with + and optionally contain the country code " +
            "followed by groups of up to four digits separated by spaces, hyphens, or periods.")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 50 characters.")]
        [Display(Name = "Your address.")]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9\s,.'-]{5,50}$", ErrorMessage = "Address must start from upper case and contain only letters, numbers, and special characters" +
            "and be from 5 to 50 characters long.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(18, 100, ErrorMessage = "You must be at least 18 years old.")]
        [Display(Name = "Your age.")]
        public int Age { get; set; }
    }

}
