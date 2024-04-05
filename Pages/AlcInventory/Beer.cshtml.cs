using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages.AlcInventory
{
    public class BeerModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public BeerModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Product> Products { get; private set; }
        public async Task OnGetAsync()
        {
            Products = await _context.Products.Where(p => p.CategoryId == 3).Select(p => new Product
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

        public async Task<IActionResult> OnPostAddToCartAsync(int productId, int quantity)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/UserLogic/Login");
            }

            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                TempData["Error"] = "Product not found.";
                return RedirectToPage();
            }

            if (quantity < 1 || quantity > product.QuantityInStock)
            {
                TempData["Error"] = "Invalid quantity.";
                return RedirectToPage(new { productId });
            }

            var userId = GetUserId();
            var cart = await GetOrCreateCartForUser(userId);
            var cartItem = await _context.CartItems
                                         .FirstOrDefaultAsync(ci => ci.CartId == cart.CartId && ci.ProductId == productId);

            if (cartItem == null)
            {
                _context.CartItems.Add(new CartItem { CartId = cart.CartId, ProductId = productId, Quantity = quantity });
            }
            else
            {
                cartItem.Quantity += quantity;
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("/Cart");
        }

        private int GetUserId()
        {
            return _context.Users.FirstOrDefault(u => u.Username == User.Identity.Name)?.UserId ?? 0;
        }

        private async Task<Cart> GetOrCreateCartForUser(int userId)
        {
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                _context.Cart.Add(cart);
                await _context.SaveChangesAsync();
            }

            return cart;
        }

    }
}
