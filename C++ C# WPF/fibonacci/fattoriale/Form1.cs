using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fattoriale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(box_input.Text);
            calcoli calcoli = new calcoli();
            box_output.Text=(calcoli.calcola_fattoriale(num)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(fib_input.Text);
            calcoli calcoli = new calcoli();
            fib_output.Text = (calcoli.calcola_fibonacci(num)).ToString();
        }
    }
}
