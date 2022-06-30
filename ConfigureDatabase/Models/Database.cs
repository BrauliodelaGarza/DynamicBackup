namespace ConfigureDatabase.Models
{
    public class Database
    {
        public int id { get; set; }
        public Conections connection { get; set; }
        public string databasename { get; set; }
        public int backupfrecuency { get; set; }
    }
}
