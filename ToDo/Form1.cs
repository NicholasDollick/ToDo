using System;
using System.Collections.Generic;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> test = new List<string>();

            test.Add("one");
            test.Add("two");
            test.Add("three");
            test.Add("four");
            test.Add("red");
            test.Add("blue");

            foreach (string s in test)
            {
                todoList.Items.Add(s);
            }
        }
    }
}
