using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages.UserLogic.Admin
{
    [Authorize(Roles = "Admin")]
    public class AddProductModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddProductModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product NewProduct { get; set; }

        public SelectList CategoryOptions { get; set; }

        public void OnGet()
        {
            CategoryOptions = new SelectList(_context.Categories, "CategoryId", "CategoryName");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("NewProduct.Category");
            ModelState.Remove("NewProduct.CartItems");
            ModelState.Remove("NewProduct.OrderDetails");

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                //change so that if the row contains more than 3 errors, the other errors go to next line
                if (errors.Count() <= 3 )
                {
                    TempData["Errors"] = string.Join("  ", errors.Select(e => e.ErrorMessage));
                }
                else
                {
                    TempData["Errors"] = string.Join("\n", errors.Select(e => e.ErrorMessage));
                }
                return Page();
            }

            _context.Products.Add(NewProduct);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Product added successfully!";
            return RedirectToPage("/UserLogic/Admin/AdminPanel");
        }
    }
}
