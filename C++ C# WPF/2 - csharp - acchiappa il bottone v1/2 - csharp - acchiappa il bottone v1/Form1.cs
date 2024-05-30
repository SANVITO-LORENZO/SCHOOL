using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2___csharp___acchiappa_il_bottone_v1
{
    public partial class Form1 : Form
    {
        int punteggio = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void label_punteggio_Click(object sender, EventArgs e)
        {
            punteggio++;
            label_punteggio.Text = "Punteggio: " + punteggio;
        }

        private void label_tempo_Click(object sender, EventArgs e)
        {

        }
    }
}
