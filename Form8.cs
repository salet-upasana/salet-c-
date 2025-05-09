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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            // TODO: This line of code loads data into the 'lockDataSet3.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.lockDataSet3.bill);
            groupBox1.Hide();
            MessageBox.Show("cick on show button  to add number of items");
            MessageBox.Show("and click on insert button to insert the record");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox26.Text))
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
                    da.InsertCommand = new OleDbCommand("INSERT INTO bill values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
                    da.InsertCommand.ExecuteNonQuery();



                    MessageBox.Show("RECORED INSERTED SUCCESSFULLY....!");
                    con.Close();


                    /*    textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox6.Text = "";
             
                        textBox8.Text = "";*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.ToString());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox26.Text))
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
                    da.InsertCommand = new OleDbCommand("INSERT INTO bill values(" + textBox6.Text + ",'" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')", con);
                    da.InsertCommand.ExecuteNonQuery();



                    MessageBox.Show("RECORED INSERTED SUCCESSFULLY....!");
                    con.Close();


                    /*    textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox6.Text = "";
             
                        textBox8.Text = "";*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.ToString());
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox26.Text))
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
                    da.InsertCommand = new OleDbCommand("INSERT INTO bill values(" + textBox11.Text + ",'" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "')", con);
                    da.InsertCommand.ExecuteNonQuery();



                    MessageBox.Show("RECORED INSERTED SUCCESSFULLY....!");
                    con.Close();


                    /*    textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox6.Text = "";
             
                        textBox8.Text = "";*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.ToString());
                }

            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox26.Text))
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
                    da.InsertCommand = new OleDbCommand("INSERT INTO bill values(" + textBox16.Text + ",'" + textBox17.Text + "','" + textBox18
                        .Text + "','" + textBox19.Text + "','" + textBox20.Text + "')", con);
                    da.InsertCommand.ExecuteNonQuery();



                    MessageBox.Show("RECORED INSERTED SUCCESSFULLY....!");
                    con.Close();


                    /*    textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox6.Text = "";
             
                        textBox8.Text = "";*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.ToString());
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox26.Text))
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
                    da.InsertCommand = new OleDbCommand("INSERT INTO bill values(" + textBox21.Text + ",'" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox25.Text + "')", con);
                    da.InsertCommand.ExecuteNonQuery();



                    MessageBox.Show("RECORED INSERTED SUCCESSFULLY....!");
                    con.Close();


                    /*    textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox7.Text = "";
                        textBox6.Text = "";
             
                        textBox8.Text = "";*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.ToString());
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            panel1.Show();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox1.Show();
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
            panel5.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
            panel5.Show();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\lock\lock.accdb";
            con = new OleDbConnection(constring);



            con.Open();
            da.SelectCommand = new OleDbCommand("select * from bill", con);


            da.Fill(ds);


            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text,textBox11.Text,textBox12.Text,textBox13.Text,textBox14.Text,textBox15.Text,textBox16.Text,textBox17.Text,textBox18.Text,textBox19.Text,textBox20.Text,textBox21.Text,textBox22.Text,textBox23.Text,textBox24.Text,textBox25.Text,textBox26.Text);
            f4.Show();
            this.Hide();
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            int v1 = int.Parse(textBox3.Text);
            int v2 = int.Parse(textBox4.Text);

            int sum = v1 * v2;
            textBox5.Text = sum.ToString();
           
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            int v1 = int.Parse(textBox8.Text);
            int v2 = int.Parse(textBox9.Text);

            int sum = v1 * v2;
            textBox10.Text = sum.ToString();
           
        }

        private void textBox14_KeyUp(object sender, KeyEventArgs e)
        {
            int v1 = int.Parse(textBox13.Text);
            int v2 = int.Parse(textBox14.Text);

            int sum = v1 * v2;
            textBox15.Text = sum.ToString();
           
        }

        private void textBox19_KeyUp(object sender, KeyEventArgs e)
        {
            int v1 = int.Parse(textBox18.Text);
            int v2 = int.Parse(textBox19.Text);

            int sum = v1 * v2;
            textBox20.Text = sum.ToString();
           
        }

        private void textBox24_KeyUp(object sender, KeyEventArgs e)
        {
            int v1 = int.Parse(textBox23.Text);
            int v2 = int.Parse(textBox24.Text);

            int sum = v1 * v2;
            textBox25.Text = sum.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
