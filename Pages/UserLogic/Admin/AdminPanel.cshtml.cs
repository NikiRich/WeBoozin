using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WeBoozin.Pages.UserLogic
{
    [Authorize(Roles = "Admin")]
    public class AdminPanelModel : PageModel
    {
       public void OnGet()
        {

        }
    }
}
