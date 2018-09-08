using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Form1 : Form
    {
        Database databaseObject = new Database();
        List<String> savedTasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
            initializeList();
        }

        //add a function to write to file when task was added to list, and when it was completed

        private void button1_Click(object sender, EventArgs e) //items should be sent to databse upon being added to the list
        {
            todoList.Items.Add(textBox1.Text);

            string query = "INSERT INTO tasks (task, date) VALUES (?, ?)";
            SQLiteCommand myCmd = new SQLiteCommand(query, databaseObject.myConnection);
        
            databaseObject.OpenConnection();
            myCmd.Parameters.AddWithValue("@task", textBox1.Text);
            myCmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("MM/dd/yy"));
            myCmd.ExecuteNonQuery();
            databaseObject.CloseConnection();


            textBox1.Text = "Add a new task"; //resets textbox state
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
                textBox1.Text = "Add a new task";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult clearAll = MessageBox.Show("Do you want to clear all completed tasks?", "", MessageBoxButtons.YesNo);

            if (todoList.Items.Count > 0) //this should also archive data to database, possible write to file with timestamp of completion?
                if (clearAll == DialogResult.Yes)
                    while (todoList.CheckedItems.Count > 0) //clear items checked as completed 
                    {
                        string updateQuery = "DELETE FROM tasks WHERE task='"+ todoList.CheckedItems[0].ToString() +"'";

                        SQLiteCommand cmd = new SQLiteCommand(updateQuery, databaseObject.myConnection);
                        databaseObject.OpenConnection();
                        cmd.ExecuteNonQuery();
                        databaseObject.CloseConnection();
                        todoList.Items.RemoveAt(todoList.CheckedIndices[0]);
                    }
            
            // consider adding option to save completed tasks, maybe having font become a strike through
            // might cause need to press update twice during a session, might look cleaner overall however
        }

        private void initializeList()
        {
            string query = "SELECT * FROM tasks";

            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                savedTasks.Add((string)reader["task"]);
            }
            reader.Close();

            foreach (string task in savedTasks)
                todoList.Items.Add(task);
        }
    }
}
