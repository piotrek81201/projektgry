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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listHistoria.Columns.Add("Propozycja", -2, HorizontalAlignment.Left);
            listHistoria.Columns.Add("Odpowiedz", -2, HorizontalAlignment.Left);
            listHistoria.Columns.Add("Czas", -2, HorizontalAlignment.Left);

            foreach (Gra.Ruch hist in Form1.g.Historia)
            {
                ListViewItem item = new ListViewItem(hist.propozycja.ToString());

                switch (hist.odpowiedz)
                {
                    case Gra.Odpowiedz.ZaMalo:
                        item.SubItems.Add("Za mało");
                        break;
                    case Gra.Odpowiedz.ZaDuzo:
                        item.SubItems.Add("Za dużo");
                        break;
                    case Gra.Odpowiedz.Trafiono:
                        item.SubItems.Add("Trafiono");
                        break;
                }
                item.SubItems.Add(hist.kiedy.ToString());
                
                listHistoria.Items.Add(item);
            }

            Controls.Add(listHistoria);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
