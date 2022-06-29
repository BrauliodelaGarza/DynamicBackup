using System.ComponentModel.DataAnnotations;

namespace ConfigureDatabase.Models
{
    public class Conections
    {
        [Key]
        int Id { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string InitialCatalog { get; set; }

    }
}
