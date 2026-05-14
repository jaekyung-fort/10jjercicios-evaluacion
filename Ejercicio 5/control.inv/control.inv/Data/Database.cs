using Microsoft.Data.SqlClient;

namespace control.inv.Data;

public static class Database
{
    public const string AppConnectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=InventarioDB;Trusted_Connection=True;TrustServerCertificate=True;";

}
