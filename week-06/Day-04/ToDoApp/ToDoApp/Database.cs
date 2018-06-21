using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace ToDoApp
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");

            if (!File.Exists("./database.sqlite3"))
            {
               SQLiteConnection.CreateFile("database.sqlite3");
                Console.WriteLine("Database added.");
            }
        }

        public void WriteInDatabase(string description, int done)
        {
            string query = "INSERT INTO user1 ('Description','Done') VALUES(@Description, @Done)";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            myCommand.Parameters.AddWithValue("@Description",description);
            myCommand.Parameters.AddWithValue("@Done", done);
            CloseConnection();
            myCommand.ExecuteNonQuery();
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
