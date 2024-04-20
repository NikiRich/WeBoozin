using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages.UserLogic
{
    [Authorize]
    public class EditProductModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditProductModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public SelectList CategoryOptions { get; set; }  // Adding SelectList for categories

        public async Task<IActionResult> OnGetAsync(int id)
        {
            // Populate CategoryOptions for the category dropdown
            CategoryOptions = new SelectList(await _context.Categories.ToListAsync(), "CategoryId", "CategoryName");

            Product = await _context.Products.FindAsync(id);
            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("Product.OrderDetails");
            ModelState.Remove("Product.CartItems");
            ModelState.Remove("Product.Category");
            CategoryOptions = new SelectList(await _context.Categories.ToListAsync(), "CategoryId", "CategoryName");

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                if (errors.Any())
                {
                    foreach (var error in errors)
                    {
                        TempData["ErrorMessage"] = error.ErrorMessage;
                    }
                }
                return Page();
            }

            try
            {
                // Check if the product exists before attempting to update
                var existingProduct = await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == Product.ProductId);
                if (existingProduct == null)
                {
                    ModelState.AddModelError("", "Product not found.");
                    return Page();
                }

                // Update the product
                _context.Attach(Product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(e => e.ProductId == Product.ProductId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            TempData["SuccessMessage"] = "Product updated successfully.";
            return RedirectToPage("/UserLogic/Admin/ProductManagement"); 
        }

    }
}
