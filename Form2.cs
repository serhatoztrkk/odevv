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

namespace biletprojesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti;
        SqlConnection komut;
        SqlDataAdapter da;
        void Getir()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select * from garson", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }
       

   



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtDurumu.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtbiletalan.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

      

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ekle_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("sp_EkleBilet2", connection);
                komut.CommandType = CommandType.StoredProcedure;

            
                komut.Parameters.AddWithValue("@satilanDurumu", bool.Parse(txtDurumu.Text));
              

                komut.ExecuteNonQuery();
            }
        }

        private void listele_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("sp_ListeleBilet", connection);
                komut.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void sil_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("sp_EkleBilet2", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@biletID", int.Parse(txtid.Text));

                komut.ExecuteNonQuery();
            }
        }

        private void güncelle_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("sp_GuncelleBilet", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@biletID", int.Parse(txtid.Text));
                komut.Parameters.AddWithValue("@satilanDurumu", bool.Parse(txtDurumu.Text));
                komut.Parameters.AddWithValue("@satinalanMusteriID", int.Parse(txtbiletalan.Text));

                komut.ExecuteNonQuery();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtDurumu.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtbiletalan.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
