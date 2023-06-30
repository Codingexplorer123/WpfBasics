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
    public partial class Liste : Form , IKayitGetir
    {
        public Liste()
        {
            InitializeComponent();
        }

    public void KayitGetir()
        {
            string ConnectionString = "Server=(localdb)\\MSSqlLocalDb; Database =TelefonRehber; Trusted_Connection=true ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string command = $"SELECT * FROM kisiListesi";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        public void Liste_Load(object sender, EventArgs e)
        {
            KayitGetir();
            
        }

        void IKayitGuncelle()
        {
          string ad = dataGridView1.CurrentRow.Cells[0].Value.ToString();
          string soyisim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          string telefon = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            string connectionString = "Server=(localdb)\\MSSqlLocalDb; Database=TelefonRehber; Trusted_Connection= true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // Normalde surekli kod tekrari yapmak dogru degil yukaridaki iki satirlik kodu public method olarak tanimlamak daha dogru fakat burda
            // kodlar aklimda kalmasi icin tekrar tekrar yaziyorum.

            string command = $"UPDATE kisiListesi SET Isim='{ad}', Soyisim='{soyisim}', [Telefon numarasi]='{telefon}'";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayit Guncellendi.");

        }
        private void btn_KayitGuncelle_Click(object sender, EventArgs e)
        {
            IKayitGuncelle();
        }

        public void KayitSil()
        {
            string isim = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string soyisim = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            string connectionString = "Server=(localdb)\\MSSqlLocalDb; Database=TelefonRehber; Trusted_Connection=true;";
            SqlConnection sqlConnection = new SqlConnection( connectionString );

            string command = $"DELETE FROM kisiListesi WHERE Isim ='{isim}' OR Soyisim='{soyisim}'";
            SqlCommand sqlCommand = new SqlCommand( command, sqlConnection );
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayit Silindi.");
        }
        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            KayitSil();
        }

        
        private void btn_Kayit_Sirala_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\MSSqlLocalDb; Database=TelefonRehber; Trusted_Connection=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString );
            string command = "SELECT * FROM [TelefonRehber].[dbo].[kisiListesi] ORDER BY [Isim] ASC;";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection );
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayitlar isim e gore siralandi.");
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
