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
            string query = string.Format("INSERT INTO user1 ('Description','Done') VALUES('{0}', {1})", description, done);
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            myCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void ReadOutDatabase()
        {
            string query = "SELECT * FROM user1";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Console.WriteLine("Id: {0}, Description: {1}, Done: {2}", result["ID"], result["Description"], result["Done"]);
                }
            }
            CloseConnection();
        }

        public void UpdateStatus(int id)
        {
            string query = string.Format("UPDATE user1 SET Done='1' WHERE ID={0}", id);
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            myCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteRecord(int id)
        {
            string query = string.Format("DELETE FROM user1 WHERE ID={0}", id);
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            myCommand.ExecuteNonQuery();
            CloseConnection();
        }

        private void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        private void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
