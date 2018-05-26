namespace ToDo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.todoList = new System.Windows.Forms.CheckedListBox();
            this.addToList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoList
            // 
            this.todoList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.todoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoList.CheckOnClick = true;
            this.todoList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoList.FormattingEnabled = true;
            this.todoList.Location = new System.Drawing.Point(27, 136);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(320, 396);
            this.todoList.TabIndex = 0;
            // 
            // addToList
            // 
            this.addToList.BackColor = System.Drawing.Color.NavajoWhite;
            this.addToList.FlatAppearance.BorderSize = 0;
            this.addToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToList.Location = new System.Drawing.Point(12, 92);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(38, 38);
            this.addToList.TabIndex = 1;
            this.addToList.Text = "+";
            this.addToList.UseVisualStyleBackColor = false;
            this.addToList.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 37);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-1, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Add a new task";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(51, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 38);
            this.panel2.TabIndex = 4;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(111, 538);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 38);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(359, 628);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addToList);
            this.Controls.Add(this.todoList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox todoList;
        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updateButton;
    }
}

