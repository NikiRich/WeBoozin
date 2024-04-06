using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;
using System.Text;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages.UserLogic
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RegisterModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NewUser NewUser { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            bool isFirstUser = !_context.Users.Any();
            var user = new User
            {
                Username = NewUser.Username,
                Password = PasswowordHash(NewUser.Password),
                Email = NewUser.Email,
                Telephone = NewUser.Telephone,
                Address = NewUser.Address,
                Name = NewUser.Name,
                Surname = NewUser.Surname,
                Age = NewUser.Age,
                Role = isFirstUser ? "Admin" : "User"
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Categories");
        }

        private string PasswowordHash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
