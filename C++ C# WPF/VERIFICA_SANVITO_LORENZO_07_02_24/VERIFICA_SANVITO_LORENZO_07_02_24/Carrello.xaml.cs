using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace VERIFICA_SANVITO_LORENZO_07_02_24
{
    /// <summary>
    /// Logica di interazione per Carrello.xaml
    /// </summary>
    public partial class Carrello : Window
    {
        float tmp = 0;
        public Carrello(ObservableCollection<Gioco> listacarrello)
        {
            InitializeComponent();
            lista_carello.ItemsSource = listacarrello;
            for (int i = 0; i < listacarrello.Count; i++)
            {
                tmp += listacarrello[i].prezzo;
            }
            TXT_PREZZO.Text = tmp.ToString();
        }

    }
}
