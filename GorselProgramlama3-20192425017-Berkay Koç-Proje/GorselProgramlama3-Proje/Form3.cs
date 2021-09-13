using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GorselProgramlama3_Proje
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        int sayac = 1;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }   
     
        private void btn_KayitOl_Click_1(object sender, EventArgs e)
        {
            if (txt_OkulNo.Text == "" | txt_Ad.Text == "" | txt_Soyad.Text == "" | txt_KullaniciAdi.Text == "" | txt_Parola.Text == "")
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurun!");
            if (sayac < 11)
            {
                baglanti = new SqlConnection("Server=.\\SQLEXPRESS; Initial Catalog=GorselProgramlama3-Proje; Integrated Security=true");
                baglanti.Open();
                string sorgu = "Insert into Gorevli_Ogrenciler(Okul_No,Ad,Soyad,Kullanici_Adi,Parola) values(@okul_no,@ad,@soyad,@kullanici_adi,@parola)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@okul_no", txt_OkulNo.Text);
                komut.Parameters.AddWithValue("@ad", txt_Ad.Text);
                komut.Parameters.AddWithValue("@soyad", txt_Soyad.Text);
                komut.Parameters.AddWithValue("@kullanici_adi", txt_KullaniciAdi.Text);
                komut.Parameters.AddWithValue("@parola", txt_Parola.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                sayac++;
            }
            else if (sayac > 10)
            {
                baglanti.Close();
                MessageBox.Show("10 Öğrenciden Fazla Kişi Kayıt Olamaz");
            }                 
        }

        private void btn_Geri_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
