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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("enter number only ");
            }

        }

         private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lockDataSet1.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.lockDataSet1.data);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {

                string query = "select * from [data] where [PRODUCT_NAME] like '%" + textBox1.Text + "%'";

                OleDbConnection con;
                OleDbDataAdapter da = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
                con = new OleDbConnection(constring);

                try
                {
                    con.Open();
                    da.SelectCommand = new OleDbCommand(query, con);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];




                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid" + ex);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
