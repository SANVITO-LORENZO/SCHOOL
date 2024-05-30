using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONCESSIONARIA
{
    public partial class Form1 : Form
    {
        int calcolo_eta = 0;
        auto auto = new auto("", "", false, false);
        string tipologia="";
        double prezzo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;

            TimeSpan diff = DateTime.Now - d;
            //** La data di partenza è 01/01/01, quindi dovremo sottrarre 1...
            DateTime eta = DateTime.MinValue + diff;
            calcolo_eta = eta.Year - 1;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(auto.cambio==false)
                auto.cambio = true;
            else
                auto.cambio=false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (auto.sensori == false)
                auto.sensori = true;
            else
                auto.sensori = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prezzo = auto.calcola_prezzo();
            if (calcolo_eta >= 40)
                prezzo = prezzo * 0.85;

            if (tipologia == "neopatentato")
                prezzo -= 1000;

            if (calcolo_eta < 21)
                prezzo = 0;

            textBox1.Text= prezzo.ToString();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            auto.motorizzazioni = "Benzina";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            auto.motorizzazioni = "Disel";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            auto.motorizzazioni = "GPL";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipologia = "neopatentato";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tipologia = "normale";
        }        
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto.modello=comboBox1.Text;
        }
    }
}
