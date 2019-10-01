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
    public partial class Lager : Form
    {
        public Lager()
        {
            InitializeComponent();
            button1.Text = "Visa bilar i lager";
            button2.Text = "Registrera mer bilar";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register NewRegister = new Register();
            NewRegister.Text = "Register new car";

            NewRegister.ShowDialog();
            this.Close();
        }
    }
}
