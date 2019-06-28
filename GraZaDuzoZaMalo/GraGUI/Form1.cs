using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        public static Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            //ToDo: try-catch ...
            var a = int.Parse(textBoxOd.Text);
            var b = int.Parse(textBoxDo.Text);

            g = new Gra(a, b);
           
            buttonLosuj.Enabled = false;
            textBoxOd.Enabled = textBoxDo.Enabled = false;
            groupBox2.Visible = true;


        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Gra.Odpowiedz odp;
            try
            {
                odp = g.Ocena(int.Parse(wprowadzanie_liczby.Text));
            }
            catch
            {
                odp = g.Ocena(0);
            }

            switch (odp)
            {
                case Gra.Odpowiedz.ZaMalo:
                    Wynik.Text = "Za mało";
                    break;
                case Gra.Odpowiedz.ZaDuzo:
                    Wynik.Text = "Za dużo";
                    break;
                case Gra.Odpowiedz.Trafiono:
                    Wynik.Text = "Trafiono";
                    break;
            }

            if(g.Stan == Gra.StanGry.Odgadnieta)
            {
                sprawdz.Enabled = false;
            }

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void Wynik_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            try
            {
                Form2 historia = new Form2();
                historia.Show();
            }
            catch
            {

            }
  
        }

        private void poddaj_Click(object sender, EventArgs e)
        {
            g.Poddaj();
            groupBox2.Visible = false;
            groupBoxLosuj.Visible = false;
            buttonNowaGra.Enabled = true;
            buttonLosuj.Enabled = true;
            textBoxOd.Enabled = textBoxDo.Enabled = true;

            MessageBox.Show("Poddałeś się ofermo","OK",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
