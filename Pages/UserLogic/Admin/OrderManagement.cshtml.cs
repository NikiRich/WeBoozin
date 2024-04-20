using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WeBoozin.Data;
using WeBoozin.Models;
using static WeBoozin.Models.Order;

namespace WeBoozin.Pages.UserLogic.Admin
{
    [Authorize(Roles = "Admin")]
    public class OrderManagementModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public OrderManagementModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<OrderView> Orders { get; set; } = new List<OrderView>();

        [BindProperty(SupportsGet = true)]
        public string SelectedStatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SelectedCategoryId { get; set; }

        public SelectList StatusOptions => new SelectList(Enum.GetValues(typeof(Order.OrderStatus)));

        public SelectList CategoryOptions { get; set; }

        public async Task OnGetAsync()
        {
            CategoryOptions = new SelectList(await _context.Categories.ToListAsync(), "CategoryId", "CategoryName");

            var ordersQuery = _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                    .ThenInclude(p => p.Category)
                .AsQueryable();

            if (!string.IsNullOrEmpty(SelectedStatus))
            {
                var status = Enum.Parse<Order.OrderStatus>(SelectedStatus);
                ordersQuery = ordersQuery.Where(o => o.Status == status);
            }

            if (SelectedCategoryId > 0)
            {
                ordersQuery = ordersQuery.Where(o => o.OrderDetails.Any(od => od.Product.CategoryId == SelectedCategoryId));
            }

            var orders = await ordersQuery.ToListAsync();

            // Ensure Orders is not null
            Orders = orders?.Select(o => new OrderView
            {
                OrderId = o.OrderId,
                Email = o.User.Email,
                Name = o.User.Name,
                Surname = o.User.Surname,
                Address = o.User.Address,
                Telephone = o.User.Telephone,
                Status = o.Status.ToString(),
                OrderItems = o.OrderDetails.Select(od => new OrderItemView
                {
                    ProductName = od.Product.ProductName,
                    Quantity = od.Quantity,
                    CategoryName = od.Product.Category.CategoryName
                }).ToList() ?? new List<OrderItemView>()
            }).ToList() ?? new List<OrderView>();
        }


        public async Task<IActionResult> OnPostUpdateStatusAsync(int orderId, Order.OrderStatus newStatus)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null)
            {
                order.Status = newStatus;
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostCancelOrderAsync(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(o => o.OrderId == orderId);

            if (order != null)
            {
                _context.OrderDetails.RemoveRange(order.OrderDetails);

                _context.Orders.Remove(order);

                await _context.SaveChangesAsync();
                TempData["CancelledOrder"] = "Order has been cancelled.";
            }
            else
            {
                TempData["Error"] = "Order not found.";
            }

            return RedirectToPage();
        }
    }
}
