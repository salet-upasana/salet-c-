using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "lock" && textBox2.Text.ToString() == "lock")
            {
                MessageBox.Show(" WELCOME,LOGIN SUCCESSFULLY....!");

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
             }
            else
            {

                MessageBox.Show("USERNAME OR PASSWORD NOT MATCH");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
