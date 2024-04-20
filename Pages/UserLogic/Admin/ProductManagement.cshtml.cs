using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages.UserLogic.Admin
{
    [Authorize(Roles = "Admin")]
    public class ProductManagementModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ProductManagementModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Product> Products { get; set; }
        public SelectList CategoryOptions { get; set; }

        [BindProperty]
        public Product NewProduct { get; set; }


        [BindProperty(SupportsGet = true)]
        public int SelectedCategoryId { get; set; }


        [BindProperty(SupportsGet = true)]
        public int? FilterQuantity { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? FilterQuantityMax { get; set; }

        public async Task OnGetAsync()
        {
            CategoryOptions = new SelectList(await _context.Categories.ToListAsync(), "CategoryId", "CategoryName");

            var productsQuery = _context.Products.AsQueryable(); // Start with all products

            // Apply category filter if a category is selected
            if (SelectedCategoryId > 0)
            {
                productsQuery = productsQuery.Where(p => p.CategoryId == SelectedCategoryId);
            }

            // Apply quantity filter if a minimum quantity is provided
            if (FilterQuantity.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.QuantityInStock >= FilterQuantity.Value);
            }

            // Apply max quantity filter if a maximum quantity is provided
            if (FilterQuantityMax.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.QuantityInStock <= FilterQuantityMax.Value);
            }

            Products = await productsQuery
                .Include(p => p.Category)
                .ToListAsync(); // Execute the query with the filters applied
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}
