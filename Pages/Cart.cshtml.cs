using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeBoozin.Models;
using WeBoozin.Data;
using Microsoft.EntityFrameworkCore;

namespace WeBoozin.Pages
{
    public class CartModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CartModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CartItem> CartItems { get; set; }

        public async Task OnGetAsync()
        {
            var userId = GetUserId();
            var cart = await _context.Cart.Include(c => c.CartItems)
                                           .ThenInclude(ci => ci.Product)
                                           .Where(c => c.UserId == userId)
                                           .FirstOrDefaultAsync();

            CartItems = cart?.CartItems.ToList() ?? new List<CartItem>();
        }

        public async Task<IActionResult> OnPostRemoveAsync(int cartItemId)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Item successfully removed from the cart.";
            }
            else
            {
                TempData["Error"] = "Item not found in the cart.";
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostIncreaseQuantityAsync(int cartItemId)
        {
            var cartItem = await _context.CartItems.Include(ci => ci.Product).FirstOrDefaultAsync(ci => ci.CartItemId == cartItemId);
            if (cartItem != null && cartItem.Quantity < cartItem.Product.QuantityInStock)
            {
                cartItem.Quantity++;
                await _context.SaveChangesAsync();
                TempData["Message"] = "Quantity increased successfully.";
            }
            else
            {
                TempData["Error"] = "Cannot increase quantity further.";
            }

            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostDecreaseQuantityAsync(int cartItemId)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);
            if (cartItem != null && cartItem.Quantity > 1)
            {
                cartItem.Quantity--;
                await _context.SaveChangesAsync();
                TempData["Message"] = "Quantity decreased successfully.";
            }
            else if (cartItem != null && cartItem.Quantity == 1)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Item removed from the cart as quantity reached zero.";
            }
            else
            {
                TempData["Error"] = "Cannot decrease quantity further.";
            }

            return RedirectToPage();
        }


        private int GetUserId()
        {
            return _context.Users.FirstOrDefault(u => u.Username == User.Identity.Name)?.UserId ?? 0;
        }
    }
}
