namespace TestingMudBlazor.CRUD.Settings
{
    public class PostgresqlSettings
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string Userid { get; set; }
        public string Password { get; set; }
        public string ConnectionString
        {
            get
            {
                string URI = $"Server={Server};Port={Port};Database={Database};User Id={Userid};Password={Password}"; //This is syntax type that Postgres expecting from us.
                return URI;
            }
        }
    }
}