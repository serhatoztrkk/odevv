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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int MusteriID { get; set; }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listele_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("sp_Listele2", connection);
                komut.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                string durum = "True";

                SqlCommand komut = new SqlCommand("sp_GuncelleBilet", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@biletID", int.Parse(textBox1.Text));
                komut.Parameters.AddWithValue("@satilanDurumu", bool.Parse(durum.ToString()));
                komut.Parameters.AddWithValue("@satinalanMusteriID", int.Parse(MusteriID.ToString()));

                MessageBox.Show("bilet alma işlemi başarılı şekilde yapılmıştır");

                komut.ExecuteNonQuery();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
