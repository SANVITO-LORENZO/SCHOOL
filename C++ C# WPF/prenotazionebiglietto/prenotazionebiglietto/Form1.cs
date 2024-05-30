using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prenotazionebiglietto
{
    public partial class Form1 : Form
    {
        double prezzo;
        bool minorenne=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 modale = new Form2();
            modale.ShowDialog();
            MessageBox.Show("CHIUSO");
            textBox2.Text=modale.destinazione.ToString();
            prezzo = modale.prezzo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                prezzo *= 1;
            if (radioButton2.Checked == true)
                prezzo *= 0.5;
            if (radioButton3.Checked == true)
                prezzo *= 0.3;
            if (minorenne)
                prezzo = prezzo - prezzo * 0.1;
            textBox4.Text = prezzo.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            TimeSpan diff = DateTime.Now - d;
            //** La data di partenza è 01/01/01, quindi dovremo sottrarre 1...
            DateTime eta = DateTime.MinValue + diff;
            
            TimeSpan diff2 = DateTime.Now - d;
            diff2.
            if(diffe)
        }
    }
}
