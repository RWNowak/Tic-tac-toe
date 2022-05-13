using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KółkoKrzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ruch = false;
        int ruchIlosc = 0;

        private void button_click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (ruch == true)
            {
                przycisk.Text = "X";
            }
            else
            {
                przycisk.Text = "O";
            }
            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;

            sprawdz();
        }
        private void sprawdz()
        {
            bool znalezionoZwyciezce = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && a1.Text != "") //rząd I
            {
                znalezionoZwyciezce = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "") //rząd II
            {
                znalezionoZwyciezce = true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && c1.Text != "") //rząd III
            {
                znalezionoZwyciezce = true;
            }
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && a1.Text != "") //kolumna I
            {
                znalezionoZwyciezce = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && a2.Text != "") //kolumna II
            {
                znalezionoZwyciezce = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && a3.Text != "") //kolumna III
            {
                znalezionoZwyciezce = true;
            }
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && a1.Text != "") //skos I
            {
                znalezionoZwyciezce = true;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && a3.Text != "") //skos 2
            {
                znalezionoZwyciezce = true;
            }

            if (znalezionoZwyciezce == true)
            {
                string zwycięzca = "";
                if (ruch)
                {
                    zwycięzca = "0";
                }
                else
                {
                    zwycięzca = "X";
                }

                MessageBox.Show("Zwycięzcą jest " + zwycięzca + "! Kliknij ok by wyczyścić planszę");
                wyczysc();
            }
            else if (ruchIlosc == 9)
            {
                MessageBox.Show("Remis! " + "Kliknij ok by wyczyścić planszę");
                wyczysc();
            }
        }
        private void wyczysc()
        {
            a1.Text = "";
            a1.Enabled = true;
            a2.Text = "";
            a2.Enabled = true;
            a3.Text = "";
            a3.Enabled = true;
            b1.Text = "";
            b1.Enabled = true;
            b2.Text = "";
            b2.Enabled = true;
            b3.Text = "";
            b3.Enabled = true;
            c1.Text = "";
            c1.Enabled = true;
            c2.Text = "";
            c2.Enabled = true;
            c3.Text = "";
            c3.Enabled = true;
            ruchIlosc = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            wyczysc();
        }
    }
}
