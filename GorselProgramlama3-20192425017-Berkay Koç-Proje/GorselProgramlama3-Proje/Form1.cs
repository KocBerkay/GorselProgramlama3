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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GorselProgramlama3-Proje;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        

        public static string _id = "admin";
        public static string _pass = "admin";     

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AdminGirisYap_Click(object sender, EventArgs e)
        {
            string _userID = txt_KullaniciAdi.Text;
            string _userPass = txt_Sifre.Text;

            if ((_userID.Length > 1) & (_userPass.Length > 1))
            {
                if ((_userID == Form1._id) & (_userPass == Form1._pass))
                {
                    Form f2 = new Form2();
                    f2.Owner = this;
                    f2.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
                MessageBox.Show("Lütfen Alanları Doldurunuz!");

            txt_Sifre.Clear();
            txt_KullaniciAdi.Clear();
            txt_KullaniciAdi.Focus();
        }

        private void btn_OgrenciKayitOl_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
            this.Hide();
        }

        bool isThere;

        private void btn_OgrenciGiris_Click(object sender, EventArgs e)
        {
            //* Burada kod doğru olmasına rağmen öğrenci kayıt olduktan sonra giriş yaptığında "Kaydınız Yok!" mesajı çıkıyor. Neden böyle olduğunu bulamadım. Form 1 tüm formların ana formu olduğu için böyle olduğunu tahmin ediyorum. *//
            string okulno = txt_OkulNo.Text;
            string ad = txt_Ad.Text;
            string soyad = txt_Soyad.Text;
            string kullaniciadi = txt_KullaniciAdi.Text;
            string parola = txt_Parola.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Gorevli_Ogrenciler",baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                if (okulno == reader["Okul_No"].ToString().TrimEnd() & ad == reader["Ad"].ToString().TrimEnd() & soyad == reader["Soyad"].ToString().TrimEnd() & kullaniciadi == reader["Kullanici_Adi"].ToString().TrimEnd() & parola == reader["Parola"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else                
                    isThere = false;               
            }
            baglanti.Close();

            if (isThere)          
                MessageBox.Show("Giriş Yapıldı!");            
            else           
                MessageBox.Show("Kaydınız Yok!");                     
        }    
    }
}

