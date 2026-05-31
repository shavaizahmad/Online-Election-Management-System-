
using System.Data.SQLite;
namespace Election_Management_System.DataBase;


    public class DBConnection
    {

    private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ElectionSystem.db");

    private static string connectionString = $"Data Source={dbPath};Version=3;";
    public static SQLiteConnection GetConnection()
        {
            SQLiteConnection con = new SQLiteConnection(connectionString);

            return con;
        }
    }

