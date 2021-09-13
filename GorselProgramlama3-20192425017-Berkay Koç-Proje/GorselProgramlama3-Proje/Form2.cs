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
    public partial class Form2 : Form
    {
        SqlConnection baglanti;      
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }

        void OgrenciGetir()
        {
            baglanti = new SqlConnection("Server=.\\SQLEXPRESS; Initial Catalog=GorselProgramlama3-Proje; Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Gorevli_Ogrenciler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            DGW_Gorevli_Ogrenciler.DataSource = tablo;
            baglanti.Close();
        }

        BindingList<Masa> MasaListesi = new BindingList<Masa>();

        private void Form2_Load(object sender, EventArgs e)
        {
            DGW_Masalar.DataSource = MasaListesi; 
            DGW_Masalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;           
            DGW_Masalar.ReadOnly = true;          
            DGW_Masalar.MultiSelect = false;        
            DGW_Masalar.Refresh();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();          
        }

        private void btn_MasaEkle_Click(object sender, EventArgs e)
        {
            int masa_id = Convert.ToInt32(txt_MasaID.Text);
            string masa_adi = txt_MasaAdi.Text;
            string masa_calisma_alani= txt_MasaCalismaAlani.Text;

            if ((txt_MasaAdi.Text.Length > 0) & (txt_MasaCalismaAlani.Text.Length > 0))
            {
                MasaListesi.Add(new Masa { id=masa_id, ad = masa_adi, calisma_alani = masa_calisma_alani });
                masa_id++;              
            }
            else
                MessageBox.Show("Lütfen alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }     

        private void btn_OgrenciGoruntule_Click_1(object sender, EventArgs e)
        {
            OgrenciGetir();
        }

        private void btn_MasaSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MasaListesi.Count > 0)            
                {
                    string silID = DGW_Masalar.SelectedRows[0].Cells[0].Value.ToString();                   
                    int _silID = int.Parse(silID);
                    for (int i = 0; i < MasaListesi.Count; i++)
                    {
                        if (MasaListesi[i].id == _silID)                       
                            MasaListesi.Remove(MasaListesi[i]);                                               
                    }
                }
                else
                    MessageBox.Show("Listede eleman yok", "Ünlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Lütfen bir satır seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DGW_Masalar.Refresh();
        }
    }
}
