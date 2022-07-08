using ConfigureDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace ConfigureDatabase.Pages.AddConection
{
    public class IndexModel : PageModel
    {
        
        public List<Conections> list = new List<Conections>();

        [BindProperty]
        public string ipAdress { get; set; }
        [BindProperty]
        public string InstanceName { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string InitialCatalog { get; set; }


        public IActionResult OnPost()
        {

            readJson();

            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();

            sqlConnectionStringBuilder.DataSource = ipAdress + "\\" + InstanceName;
            sqlConnectionStringBuilder.UserID = Username;
            sqlConnectionStringBuilder.Password = Password;
            sqlConnectionStringBuilder.InitialCatalog = InitialCatalog;

            Conections con = new Conections(1, sqlConnectionStringBuilder.DataSource, sqlConnectionStringBuilder);
            writeJson(con);

            return Redirect("/AddConnection");
        }

        public void OnGet()
        {

        }

        public void writeJson(Conections conections)
        {
            this.list.Add(conections);

            string jsonstring = JsonConvert.SerializeObject(list, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter("Json/ConnectionsConfig.json"))
            {
                writer.Write(jsonstring);
            }
        }

        public void readJson()
        {
            using (StreamReader r = new StreamReader("Json/ConnectionsConfig.json"))
            {
                string json = r.ReadToEnd();
                this.list = JsonConvert.DeserializeObject<List<Conections>>(json);
            }
        }
    }
}
