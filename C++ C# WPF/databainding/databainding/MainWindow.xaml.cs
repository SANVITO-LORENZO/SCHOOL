using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace databainding
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<persona> persone;
        public MainWindow()
        {
            InitializeComponent();
            persone = new ObservableCollection<persona>();  
            GRIGLIA.ItemsSource= persone;
            lista.ItemsSource = persone;
        }

        private void btt_Click(object sender, RoutedEventArgs e)
        {
            persona tmp = new persona(nome.Text,cognome.Text);
            persone.Add(tmp);
        }

        private void btt1_Click(object sender, RoutedEventArgs e)
        {
            persona tmp = lista.SelectedItem as persona;
            if (tmp != null)
            {
                tmp.Name = "PIPPO";
            }
        }

        public void salva()
        {
            
            StreamWriter sw = new StreamWriter("file.txt");
            foreach (persona persona in persone)
            {
                sw.WriteLine(persona.toCSV());
            }
            sw.Close();
            sw.Dispose();
        }

        public List<persona> Carica(string filename)
        {
            List<persona> lista = new List<persona>();
            StreamReader sr = new StreamReader(filename);
            while(!sr.EndOfStream)
            {
                string row= sr.ReadLine();
                lista.Add(persona.parse(row));
            }
            sr.Close();
            sr.Dispose();
            return lista;
        }

        public void bottone_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            bool? result = ofd.ShowDialog();
            if (result != false && result.HasValue && result==true) 
            {
                string path= ofd.FileName;
                string nome = ofd.SafeFileName;
                txt.Text = path;
                txt2.Text = nome;
            }
        }
    }
}
