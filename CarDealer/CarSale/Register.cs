using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSale
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
            label1.Text = "Make";
            label2.Text = "Model";
            label3.Text = "Regnr";
            label4.Text = "Kilometer";
            label5.Text = "Price";
            button1.Text = "Registrera";
            button2.Text = "Gå till lager";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lager NewLager = new Lager();
            NewLager.Text = "Cars in storage";

            NewLager.ShowDialog();
            this.Close();
        }
    }
}
