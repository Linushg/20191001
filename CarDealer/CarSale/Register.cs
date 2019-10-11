using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarNameSpace;
using RepositoryNameSpace;

namespace CarSale
{

    public partial class Register : Form
    {
        Repository repoLager = new Repository();

        //public string Make = "BMW";

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
            //CarInfo Make = "BMW";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lager NewLager = new Lager();
            NewLager.Text = "Cars in storage";

            NewLager.ShowDialog();
            this.Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("{0}", Make);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarInfo c = new CarInfo() { Make = textBox1.Text, Model = textBox2.Text, Regnr = textBox3.Text, Kilometer = textBox4.Text, Price = textBox5.Text };
            repoLager.Save(c);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            listBox1.Items.Add(c);
            
        }
    }
}
