using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonrehberi
{
    public partial class ListeKayit : Form
    {
        public ListeKayit()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

      
        public void KayitGetir()
        {
            string ConnectionString = "Server=(localdb)\\MSSqlLocalDb; Database =TelefonRehber; Trusted_Connection=true ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string command = "SELECT * FROM kisiListesi";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }
        private void ListeKayit_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }


        public void Kaydet()
        {
            string isim = txt_isim.Text;
            string soyIsim = txt_soyisim.Text;
            string numara = txt_telefon.Text;

            string connectionString = "Server=(localdb)\\MSSqlLocalDb; Database=TelefonRehber; Trusted_Connection=true ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string command = $"INSERT INTO kisiListesi(Isim, Soyisim, [Telefon numarasi]) VALUES ('{isim}','{soyIsim}','{numara}')";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayit Yapildi..");
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            txt_isim.Text = "";
            txt_soyisim.Text = "";
            txt_telefon.Text = "";
        }
    }
}
