using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace databainding
{
    public  class persona : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public persona(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DataDiNascita { get; set; }
 
        public string toCSV()
        {
            return Name.Replace(";"," ") + ";" + Surname + ";" + DataDiNascita + "\r\n";
        }

        public static persona parse(string s)
        {
            string[] campi = s.Split(';');
            persona tmp = new persona(campi[0], campi[1]);
            tmp.DataDiNascita = DateTime.Parse(campi[2]);
            return tmp;
        }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
