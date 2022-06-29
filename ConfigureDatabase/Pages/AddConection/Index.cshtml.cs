using ConfigureDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConfigureDatabase.Pages.AddConection
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public Conections connection { get; set; } 
        public string ipadress { get; set; }
        public string instance { get; set; }
        public string username { get; set; } = " ";
        public string password { get; set; } = " ";
        public string initialcatalog { get; set; } = " ";

        public void OnPostSubmit(string ipadress)
        {
            this.ipadress = ipadress;
        }

        public void OnGet()
        {
        }
    }
}
