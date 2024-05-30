using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace COMPITOINFO
{
    /// <summary>
    /// Logica di interazione per scelta_squadra.xaml
    /// </summary>
    public partial class scelta_squadra : Window
    {
        private bool scelta=false;      //variabile che permette di capire che squadra ha selezionato l'utente

        //metodi set e get
        public bool Scelta { get => scelta; set => scelta = value; }

        public scelta_squadra()
        {
            InitializeComponent();
            //il primo radiobutton verrà selezionato
            radiobuttn_1.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //se viene selezionato il primo radio button la variabile scelta sarà false 
            if (radiobuttn_1.IsChecked == true)
                scelta = false;
        }
        private void radiobuttn_2_Checked(object sender, RoutedEventArgs e)
        {
            //se viene selezionato il secondo radio button la variabile scelta sarà false 
            if (radiobuttn_2.IsChecked == true)
                scelta = true;
        }

        private void btt_Click(object sender, RoutedEventArgs e)
        {
            //la finestra verrà chiusa
            this.Close();
        }


    }
}
