using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "1";
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "2";
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "3";
        }
        private void b_4_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "4";
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "5";
        }
        private void b_6_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "6";
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "7";
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "8";
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "9";
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + "0";
        }

        private void b_piu_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + " + ";
        }

        private void b_meno_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + " - ";
        }

        private void b_per_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + " * ";
        }

        private void b_diviso_Click(object sender, EventArgs e)
        {
            schermo.Text = schermo.Text + " / ";
        }

        private void b_uguale_Click(object sender, EventArgs e)
        {

        }

        private void schermo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
