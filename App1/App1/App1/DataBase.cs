using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace App1
{
    class DataBase
    {
        public SQLiteConnection myConnection;
        public DataBase() {
            MainPage label = new MainPage();
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");
            if (!File.Exists("./database.sqlite3")) {
                SQLiteConnection.CreateFile("database.sqlite3");
                label.Test1Lab.Text ="data base has been created";
            }
            else{
                label.Test1Lab.Text = "data base has not been created";
            }
        }
    }
}
