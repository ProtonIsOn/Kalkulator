using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        Double Rezultat = 0;
        String Matematicka_radnja = "";
        bool MatematickaRadnjaUnesena = false ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Unos(object sender, EventArgs e)
        {
            if (Ekran.Text == "0") Ekran.Clear();
            if (MatematickaRadnjaUnesena)
            {
                Ekran.Clear();
            }
            
            MatematickaRadnjaUnesena = false;
            Izracun.Text = Rezultat + " " + Matematicka_radnja;
            Button Broj = (Button)sender;
            if( Broj.Text == ".")
                {
                if (!Ekran.Text.Contains("."))
                    Ekran.Text = Ekran.Text + Broj.Text;
                } else
            Ekran.Text = Ekran.Text + Broj.Text;
            
           
           
        }

        private void Matematicka_Operacija(object sender, EventArgs e)
        {
            Button Operacija = (Button)sender;
            Matematicka_radnja = Operacija.Text;
            
            if (!MatematickaRadnjaUnesena)
            {
                Rezultat = double.Parse(Ekran.Text);
                Izracun.Text = Rezultat.ToString();
            }
            MatematickaRadnjaUnesena = true; 
            Ekran.Clear();
            Izracun.Text = Rezultat + " " + Matematicka_radnja;
        }

        private void Obrisi_Zadnji_Unos(object sender, EventArgs e)
        {
            Ekran.Text = "0";
        }

        private void Obrisi_Rezultat(object sender, EventArgs e)
        {
            Rezultat = 0;
            Ekran.Text = "0";
        }

        private void Poz_Neg(object sender, EventArgs e)
        {
            Ekran.Text = (Double.Parse(Ekran.Text) * -1).ToString();
        }

        private void Izracunaj(object sender, EventArgs e)
        {
            Izracun.Text = "";
            
            
                switch (Matematicka_radnja)
                {
                    case "+":
                        Ekran.Text = (Rezultat + Double.Parse(Ekran.Text)).ToString();
                        
                        break;
                    case "-":
                        Ekran.Text = (Rezultat - Double.Parse(Ekran.Text)).ToString();
                        break;
                    case "*":
                        Ekran.Text = (Rezultat * Double.Parse(Ekran.Text)).ToString();
                        break;
                    case "/":
                        Ekran.Text = (Rezultat / Double.Parse(Ekran.Text)).ToString();
                        break;
                    default:
                        break;
                }
            MatematickaRadnjaUnesena = true;
            Izracun.Text = Ekran.Text;
            Rezultat = Double.Parse(Ekran.Text);
        }

       
    }
}
