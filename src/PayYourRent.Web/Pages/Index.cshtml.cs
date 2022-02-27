using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayYourRent.Web.Pages;

public class Index : PageModel
{
    public async Task<IActionResult> OnGetAsync()
    {
        return Page();
    }
}