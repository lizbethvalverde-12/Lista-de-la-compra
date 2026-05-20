using Microsoft.Data.Sqlite;

namespace TodoMVC.Data;

public static class Database
{
    private const string ConnectionString = "Data Source=tareas.db";

    public static void Inicializar()
    {
        using var connection = AbrirConexion();
        var sql = @"
            CREATE TABLE IF NOT EXISTS Productos (
                Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre   TEXT    NOT NULL,
                Cantidad INTEGER NOT NULL,
                Comprado INTEGER NOT NULL DEFAULT 0
            )";
        using var cmd = new SqliteCommand(sql, connection);
        cmd.ExecuteNonQuery();
    }

    public static SqliteConnection AbrirConexion()
    {
        var connection = new SqliteConnection(ConnectionString);
        connection.Open();
        return connection;
    }
}


