using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;

namespace ConfigureDatabase.Models
{
    public class Conections
    {

        [Required]
        int Id { get; set; }
        [Required]
        public string ConnectionName { get; set; }
        [Required]
        public SqlConnectionStringBuilder stringBuilder { get; set; }

        public Conections(int id, string connectionName, SqlConnectionStringBuilder stringBuilder)
        {
            Id = id;
            ConnectionName = connectionName;
            this.stringBuilder = stringBuilder;
        }
    }
}
