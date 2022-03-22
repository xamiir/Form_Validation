using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15murchform
{
    public partial class form_Save : Form
    {
        public form_Save()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstNameText = textBox1.Text;
            string lastNameText = textBox2.Text;
           
           label11.Text=firstNameText+lastNameText;

            string m = textBox3.Text;
            string d = textBox4.Text;
            string Y = textBox5.Text;
            string date = textBox3.Text + " " + textBox4.Text + " " + textBox3.Text;
            label9.Text=date;






        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_Save_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
