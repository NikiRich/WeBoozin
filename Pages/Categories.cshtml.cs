using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeBoozin.Data;
using WeBoozin.Models;

namespace WeBoozin.Pages
{
    public class CategoriesModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CategoriesModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Category> Categories { get; private set; }

        public async Task OnGetAsync()
        {
            Categories = await _db.Categories.ToListAsync();
        }
    }
}
