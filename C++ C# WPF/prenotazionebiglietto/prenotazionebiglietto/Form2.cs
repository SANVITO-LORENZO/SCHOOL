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
    public partial class Form2 : Form
    {
        CCitta citta = new CCitta("");
        int _prezzo = 0;
        string _destinazione = "";

        public string destinazione
        {
            get { return _destinazione; }
        }

        public int prezzo
        {
            get { return _prezzo; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            citta.setNome((string)listBox1.SelectedItem);
            _prezzo=citta.calcolaPrezzo();
            _destinazione = citta.getNome();
        }
    }
}
