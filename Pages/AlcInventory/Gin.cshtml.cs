using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeBoozin.Models;
using WeBoozin.Data;
using Microsoft.EntityFrameworkCore;

namespace WeBoozin.Pages.AlcInventory
{
    public class GinModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public GinModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Product> Products { get; private set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.Where(p => p.CategoryId == 5).Select(p => new Product
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Description = p.Description,
                QuantityInMl = p.QuantityInMl,
                QuantityInStock = p.QuantityInStock,
                Image = p.Image,
                AlcoholContent = Math.Round(p.AlcoholContent, 2),
            }).ToListAsync();
        }
    }
}
