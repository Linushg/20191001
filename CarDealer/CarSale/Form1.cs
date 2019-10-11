using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepositoryNameSpace;

namespace CarSale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Registrera ny bil";
            button2.Text = "Se bilar i lager";
            label1.Text = "Welcome to Acme Car sales";
            label2.Text = "Pick an option";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register NewRegister = new Register();
            NewRegister.Text = "Register new car";

            NewRegister.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lager NewLager = new Lager();
            NewLager.Text = "Cars in storage";

            NewLager.ShowDialog();
            this.Close();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
