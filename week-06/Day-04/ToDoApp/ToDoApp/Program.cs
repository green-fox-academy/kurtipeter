using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database databaseObj = new Database();
            databaseObj.ReadOutDatabase();
            databaseObj.WriteInDatabase(@"raiding shores", 0);
            databaseObj.ReadOutDatabase();
            //int deleteRecord = Int32.Parse(Console.ReadLine());
            //databaseObj.DeleteRecord(deleteRecord);
            Console.ReadLine();
        }
    }
}
