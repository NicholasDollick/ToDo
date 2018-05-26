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

        private void button1_Click(object sender, EventArgs e) //items should be sent to databse upon being added to the list
        {

            //test.Add(textBox1.Text);

            todoList.Items.Add(textBox1.Text);
          

            textBox1.Text = "Add a new task";
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
            {
                SQLiteCommand myCmd = new SQLiteCommand();
                myCmd.Connection = databaseObject.myConnection;
                myCmd.CommandType = CommandType.Text;
                databaseObject.OpenConnection();
                for (int i = 0; i < todoList.Items.Count; i++)
                {
                    myCmd.CommandText = "INSERT INTO tasks (task, date) VALUES (?, ?)";
                    myCmd.Parameters.AddWithValue("@task", todoList.Items[i].ToString());
                    myCmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("MM/dd/yy"));
                    myCmd.ExecuteNonQuery();
                    myCmd.Parameters.Clear();
                }
                databaseObject.CloseConnection();

                if(clearAll == DialogResult.Yes)
                    while (todoList.CheckedItems.Count > 0) //clear items checked as completed 
                        todoList.Items.RemoveAt(todoList.CheckedIndices[0]);
            }
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
