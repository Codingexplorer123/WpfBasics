using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonrehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cikis isleminiz yapilmistir.");
            Application.Exit();
        }

        private void btn_TelefonNumarasiKaydet_Click(object sender, EventArgs e)
        {
            ListeKayit listeKayit = new ListeKayit();
            listeKayit.Show();
            this.Hide();
        }

        public void KayitSil()
        {

        }
        private void btn_TelefonNumarasiSil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Liste liste = new Liste();
            liste.Show();

        }

        private void btn_TelefonNumarasiGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Liste liste = new Liste();
             liste.Show();
        }

        private void btn_RehberListeleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Liste liste = new Liste();
            liste.Show();
        }

        private void btn_RehberArama_Click(object sender, EventArgs e)
        {
            this.Hide();
            Liste liste = new Liste();
            liste.Show();
        }
    }
}
