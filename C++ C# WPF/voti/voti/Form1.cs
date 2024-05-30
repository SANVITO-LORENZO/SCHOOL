using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace voti
{
    public partial class Form1 : Form
    {
        //lista
        List<float> list = new List<float>();
        //cordinate 
        int cordx=0; int cordy=200;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conta quanti elementi contiene la lista
            //list.Count();
            float num =Int32.Parse(textBox1.Text);
            if (num > 1 && num <= 10)
            {
                //// Converti il float in una stringa
                //string tmp = num.ToString();

                //// Ottieni la substring della parte decimale
                //tmp = tmp.Substring(tmp.IndexOf(".") + 1);

                //// Ottieni il primo carattere della substring
                //char primaCifraDecimale = tmp.First();
                //if (primaCifraDecimale == 5 || primaCifraDecimale == 0)
                //{
                    list.Add(num);
                    textBox2.Text = list.Average().ToString();
                //}
                
                Panel tmp = new Panel();
                tmp.Size = new Size(20, 10*(int)num );
                tmp.Location = new Point(cordx, cordy- 10 * (int)num);
                tmp.BackColor = Color.Black;
                panel1.Controls.Add(tmp);
                cordx += 50 ;

            }
            textBox1.Clear();     
        }
    }
}
