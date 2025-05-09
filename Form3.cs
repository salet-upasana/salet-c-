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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||  string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) ||string.IsNullOrWhiteSpace(textBox4.Text) ||string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            else
            {
                OleDbConnection con;
                OleDbDataAdapter da = new OleDbDataAdapter();
                String constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
                con = new OleDbConnection(constring);
                try
                {
                    con.Open();
                    da.InsertCommand = new OleDbCommand("INSERT INTO data values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
                    da.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("RECORED INSERTED SUCCESSFULLY..!");
                    con.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.ToString());
                }

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {

                OleDbConnection con;
                OleDbDataAdapter da = new OleDbDataAdapter();
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
                con = new OleDbConnection(constring);

                try
                {
                    con.Open();
                    da.DeleteCommand = new OleDbCommand("delete * from data where PRODUCT_ID=" + textBox1.Text, con);
                    da.DeleteCommand.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("RECORED DELETED SUCCESSFULLY...!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.ToString());
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da = new OleDbDataAdapter();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
            con = new OleDbConnection(constring);

            try
            {
                con.Open();

                da.UpdateCommand = new OleDbCommand("update data set PRODUCT_NAME='" + textBox2.Text + "',BRAND_NAME= '" + textBox3.Text + "',PRICE_OF_PRODUCT='" + textBox4.Text + "',DESCRIPTION='" + textBox5.Text + "' where PRODUCT_ID =" + textBox1.Text, con);

                da.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("RECORED UPDATED SUCCESSFULLY..!");
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
            con = new OleDbConnection(constring);

            try
            {
                con.Open();
                da.SelectCommand = new OleDbCommand("select * from data where PRODUCT_ID="+textBox1.Text, con);
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                foreach (DataRow row in dt.Rows)
                {
                  textBox2.Text+=row["PRODUCT_NAME"].ToString()+Environment.NewLine;
                  textBox3.Text += row["BRAND_NAME"].ToString() + Environment.NewLine;
                  textBox4.Text += row["PRICE_OF_PRODUCT"].ToString() + Environment.NewLine;
                  textBox5.Text += row["DESCRIPTION"].ToString() + Environment.NewLine;
                }

                
                
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid" + ex);
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lockDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.lockDataSet.data);
            fillgrid();

        }
        public void fillgrid()
        {
            OleDbConnection con;
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
            con = new OleDbConnection(constring);

            try
            {
                con.Open();
                da.SelectCommand = new OleDbCommand("select * from data", con);


                da.Fill(ds);


                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid" + ex);
            }
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("enter number only ");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("enter letter only ");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("enter letter ");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("enter number only ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
            con = new OleDbConnection(constring);

            try
            {
                con.Open();
                da.SelectCommand = new OleDbCommand("select * from data", con);


                da.Fill(ds);


                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid" + ex);
            }
        }

    
      
    }
    }
