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
    public partial class Form4 : Form
    {     
        SqlDataAdapter da;
        SqlCommand komut;
        public Form4()
        {
            InitializeComponent();
        }
      
        Basari b = new Basari();

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GorselProgramlama3-Proje;Integrated Security=True");
        
        void SecilenGetir()
        {
            baglanti = new SqlConnection("Server=.\\SQLEXPRESS; Initial Catalog=GorselProgramlama3-Proje; Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Secilenler", baglanti);
            DataTable tb = new DataTable();
            da.Fill(tb);
            DGW_Secilenler.DataSource = tb;
            baglanti.Close();
        }

        //* Aşağıdaki dizilerde her sayı bir elemanı ifade eder. Örnek: 1 --> 1. Öğrenci ya da Aile ya da Masa *//
        int[] aileler = { 1, 2, 3,4,5,6,7,8,9,10,
                          11, 12, 13,14,15,16,17,18,19,20,
                          21, 22, 23,24,25,26,27,28,29,30 };
        int[] ogrenciler = {1,2,3,4,5,6,7,8,9,10};

        int[] masalar = {1,2,3,4,5,6,7,8,9,10};

        private void Form4_Load(object sender, EventArgs e)
        {
            SecilenGetir();
        }

        int tiklanmasayisi = 0;
        private void btn_AileSec_Click(object sender, EventArgs e)
        {        
            if (tiklanmasayisi <30)
            {   btn_AileSec.Text = "Aile Seç--> " + (++tiklanmasayisi).ToString() + " Kez Seçildi";
                Random r = new Random();
                int rastgele1 = r.Next(0, aileler.Length);

                Random ra = new Random();
                int rastgele2 = ra.Next(0, ogrenciler.Length);

                Random ran = new Random();
                int rastgele3 = ran.Next(0, masalar.Length);

                MessageBox.Show("Seçilen Öğrenci: " + ogrenciler[rastgele2]);
                MessageBox.Show("Seçilen Aile: " + aileler[rastgele1]);
                MessageBox.Show("Yollanan Masa: " + masalar[rastgele3]);
                MessageBox.Show("Başarılı Oldu Mu?: " +b.basari());

                int ogrenci_id = ogrenciler[rastgele2];
                int aile_id = aileler[rastgele1];
                int masa_id = masalar[rastgele3];

                baglanti = new SqlConnection("Server=.\\SQLEXPRESS; Initial Catalog=GorselProgramlama3-Proje; Integrated Security=true");
                baglanti.Open();
                string sorgu = "Insert into Secilenler (SecilenAile_ID,SecilenOgrenci_ID,YollananMasa_ID,Basari) values(@secilen_aile,@secilen_ogrenci,@yollanan_masa,@basari)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@secilen_aile",aileler[rastgele1]);
                komut.Parameters.AddWithValue("@secilen_ogrenci",ogrenciler[rastgele2]);
                komut.Parameters.AddWithValue("@yollanan_masa", masalar[rastgele3]);
                komut.Parameters.AddWithValue("@basari", b.basari());
                komut.ExecuteNonQuery();
                baglanti.Close();
                DGW_Secilenler.Refresh();
                SecilenGetir();
            }
              else if(tiklanmasayisi==30)
              MessageBox.Show("30 Aileden Fazla Aile Seçilemez!");
        }    

        private void DGW_Secilenler_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.DGW_Secilenler.Columns["Desc"].SortMode = DataGridViewColumnSortMode.Automatic;
        }            
    }
}
