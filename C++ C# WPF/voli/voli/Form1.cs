using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voli
{
    public partial class Form1 : Form
    {
        string stampa = "";
        double prezzo;
        bool classe=false;
        int giornopartenza;
        int mesepartenza;
        int annopartenza;
        int giornoprenotazione;
        int meseprenotazione;
        int annoprenotazione;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "BARCELLONA" || comboBox1.Text == "LONDRA" || comboBox1.Text == "PARIGI")
                prezzo += 200;
            if (comboBox1.Text == "LIONE" || comboBox1.Text == "VARSAVIA")
                prezzo += 150;
            if (classe==true)
                prezzo=prezzo*1.3;

            stampa += textBox2.Text +"\r\n";
            stampa += "le confermiamo la prenotazione a " + comboBox1.Text + "\r\n";
            stampa += "con partenza"+ giornopartenza+"/"+mesepartenza+"/"+annopartenza + "\r\n";
            stampa += "al prezzo di " + prezzo + "\r\n";
            textBox1.Text= stampa;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            classe = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            classe = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;

            TimeSpan diff = DateTime.Now - d;
            //** La data di partenza è 01/01/01, quindi dovremo sottrarre 1...
            DateTime eta = DateTime.MinValue + diff;

            annopartenza = (eta.Year - 1);
            mesepartenza = (eta.Month - 1);
            giornopartenza = (eta.Day - 1);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;

            TimeSpan diff = DateTime.Now - d;
            //** La data di partenza è 01/01/01, quindi dovremo sottrarre 1...
            DateTime eta = DateTime.MinValue + diff;

            annoprenotazione = (eta.Year - 1);
            meseprenotazione = (eta.Month - 1);
            giornoprenotazione = (eta.Day - 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="BARCELLONA")
                pictureBox1.ImageLocation = @".\images\0" + comboBox1.SelectedIndex + ".jpg";
            if (comboBox1.Text == "LIONE")
                pictureBox1.ImageLocation = @".\images\1" + comboBox1.SelectedIndex + ".jpg";
            if (comboBox1.Text == "LONDRA")
                pictureBox1.ImageLocation = @".\images\2" + comboBox1.SelectedIndex + ".jpg";
            if (comboBox1.Text == "PARIGI")
                pictureBox1.ImageLocation = @".\images\3" + comboBox1.SelectedIndex + ".jpg";
            if (comboBox1.Text == "VARSAVIA")
                pictureBox1.ImageLocation = @".\images\4" + comboBox1.SelectedIndex + ".jpg";

        }
    }
}
