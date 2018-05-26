
using System.Data.SQLite;
using System.IO;

namespace ToDo
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite");
     
            //initialize databse with proper row/col values
            if (!File.Exists("./database.sqlite"))
            {
                string users = "CREATE TABLE \"users\"(\"username\" TEXT NOT NULL  check(typeof(\"username\") = 'text') , \"password\" TEXT NOT NULL check(typeof(\"password\") = 'text') )";
                string tasks = "CREATE  TABLE \"main\".\"tasks\" (\"task\" TEXT check(typeof(\"task\") = 'text') , \"date\" TEXT check(typeof(\"date\") = 'text')  DEFAULT CURRENT_DATE)";

                SQLiteConnection.CreateFile("database.sqlite");
                myConnection.Open();
                SQLiteCommand createUser = new SQLiteCommand(users, myConnection);
                SQLiteCommand createTasks = new SQLiteCommand(tasks, myConnection);
                createUser.ExecuteNonQuery();
                createTasks.ExecuteNonQuery();
                myConnection.Close();
            }
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
