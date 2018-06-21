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

        public void WriteInDatabase()
        {
            string query = "INSERT INTO user1 ('Description','Done') VALUES(@Description, @Done)";
        }
    }
}
