using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void RD_Korisnik_CheckedChanged(object sender, EventArgs e)
        {
            if(RD_Korisnik.Checked)
            {
                GRP_Korisnik.Show();
            }
            else
            {
                GRP_Korisnik.Hide();
            }
        }

        private void RD_Knjiga_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Knjiga.Checked)
            {
                GRP_Knjiga.Show();
            }
            else
            {
                GRP_Knjiga.Hide();
            }
        }

        private void RD_Evidencija_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Evidencija.Checked)
            {
                GRP_Evidencija.Show();
            }
            else
            {
                GRP_Evidencija.Hide();
            }
        }
    }
}
