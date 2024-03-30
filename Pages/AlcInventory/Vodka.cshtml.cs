using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages.Alcohol_Inventory
{
    public class VodkaModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public VodkaModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Product> Products { get; private set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.Where(p => p.CategoryId == 1).Select(p => new Product
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
