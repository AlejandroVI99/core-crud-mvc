using System.Data.SqlClient;

namespace CRUDCORE.Datos
{
    public class Conexion
    {
        private string stringSQL = string.Empty;

        //constructor
        public Conexion() {
            //get string conection of the appsettings
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            stringSQL = builder.GetSection("ConnectionStrings:StringConection").Value;
        }

        public string getCadenaSQL() {
            return stringSQL;
        }
    }
}