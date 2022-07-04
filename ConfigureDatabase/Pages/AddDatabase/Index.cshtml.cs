using ConfigureDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConfigureDatabase.Pages.AddDatabase
{
    public class IndexModel : PageModel
    {
        public Database database { get; set; }
        public List<string> connections = new List<string>();   
        public List<string> Frecuency { get; set; }  

        public IActionResult OnPost()
        {
            return Redirect("AddConnection");
        }

        public void OnGet()
        {
        }

        public void AddConn()
        {

        }

        public void AddFrecuency()
        {

        }
    }
}
