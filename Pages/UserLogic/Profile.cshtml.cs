using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages.UserLogic
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ProfileModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserUpdate UserUpdate { get; set; }
        public List<OrderView> Orders { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == userEmail);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            var orders = await _context.Orders
                .Where(o => o.UserId == user.UserId)
                .Select(o => new OrderView
                {
                    OrderId = o.OrderId,
                    Status = o.Status.ToString(),
                    OrderItems = o.OrderDetails.Select(od => new OrderItemView
                    {
                        ProductName = od.Product.ProductName,
                        Quantity = od.Quantity,
                        CategoryName = od.Product.Category.CategoryName
                    }).ToList()
                }).ToListAsync();

            UserUpdate = new UserUpdate
            {
                Name = user.Name,
                Surname = user.Surname,
                Telephone = user.Telephone,
                Address = user.Address
            };
            Orders = orders;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            var userToUpdate = await _context.Users.FirstOrDefaultAsync(u => u.Email == userEmail);

            if (userToUpdate == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToPage();
            }

            userToUpdate.Name = UserUpdate.Name;
            userToUpdate.Surname = UserUpdate.Surname;
            userToUpdate.Telephone = UserUpdate.Telephone;
            userToUpdate.Address = UserUpdate.Address;

            if (!string.IsNullOrWhiteSpace(UserUpdate.NewPassword))
            {
                if (UserUpdate.NewPassword != UserUpdate.ConfirmPassword)
                {
                    ModelState.AddModelError("", "The new password and confirmation password do not match.");
                    return Page();
                }

                var newHashedPassword = PasswordHash(UserUpdate.NewPassword);
                if (newHashedPassword != userToUpdate.Password)
                {
                    userToUpdate.Password = newHashedPassword;
                }
                else
                {
                    TempData["Error"] = "New password cannot be the same as the old one.";
                    return RedirectToPage();
                }
            }

            _context.Users.Update(userToUpdate);
            await _context.SaveChangesAsync();

            TempData["Message"] = "Profile updated successfully.";
            return RedirectToPage();
        }


        private string PasswordHash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
