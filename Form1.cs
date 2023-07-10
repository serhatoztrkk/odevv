using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace biletprojesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("sp_yöneticiGiris", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@kullaniciAdi", txtkulanıcıad.Text);
                komut.Parameters.AddWithValue("@sifre", txtsifre.Text);



                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    

                    Form2 ft = new Form2();
                    ft.Show();
                    this.Hide();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }

                dr.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8O5MUCC6;Initial Catalog=projebilet;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("sp_MusteriGiris", connection);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@kullaniciAdi", txtkulanıcıad.Text);
                komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
              


                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    int musteriID = Convert.ToInt32(dr["musteriID"]);

                    Form3 ft = new Form3();
                    ft.MusteriID = musteriID; 
                    ft.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }

                dr.Close();
            }
        }
    }
}
