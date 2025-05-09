using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace project
{
    public partial class Form4 : Form
    {




        public Form4(string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10, string d11, string d12, string d13, string d14, string d15, string d16, string d17, string d18, string d19, string d20, string d21, string d22, string d23, string d24, string d25, string d26)
        {
            InitializeComponent();


            label17.Text = d26;
            label18.Text = d1;
            label19.Text = d2;
            label20.Text = d3;
            label21.Text = d4;
            label22.Text = d5;
            label23.Text = d6;
            label24.Text = d7;
            label25.Text = d8;
            label26.Text = d9;
            label27.Text = d10;
            label28.Text = d11;
            label29.Text = d12;
            label30.Text = d13;
            label31.Text = d14;
            label32.Text = d15;
            label33.Text = d16;
            label34.Text = d17;
            label35.Text = d18;
            label36.Text = d19;
            label37.Text = d20;
            label38.Text = d21;
            label39.Text = d22;
            label40.Text = d23;
            label41.Text = d24;
            label42.Text = d25;

          /*  int v1 = int.Parse(label22.Text);
            int v2 = int.Parse(label27.Text);
            int v3 = int.Parse(label32.Text);
            int v4 = int.Parse(label37.Text);
            int v5 = int.Parse(label42.Text);

            int sum =  v1 + v2 + v3 + v4 + v5;
            label16.Text = sum.ToString();*/
           



        }
        /* private void SaveToFile(string data)
         {
             // Define the path for the text file
             string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "User.txt");

             // Write the data to the file
             try
             {
                 File.WriteAllText(filePath, data);
                 MessageBox.Show("Data saved to: {filePath}");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("An error occurred: {ex.Message}");
             }
         }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }






        private void Form4_Load_1(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToShortDateString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            /*  string name = label15.Text;
        


              // Create a string to save
              string dataToSave = "Name:" + label15.Text;
        

              // Save to text file
              SaveToFile(dataToSave);

          }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}