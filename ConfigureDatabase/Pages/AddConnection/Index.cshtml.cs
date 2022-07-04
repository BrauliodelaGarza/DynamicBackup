using ConfigureDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConfigureDatabase.Pages.AddConection
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public Conections connection { get; set; } 

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return null;
            }



            return Redirect("/AddConection");
        }

        public void OnGet()
        {
        }
    }
}
