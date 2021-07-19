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
using System.Runtime.InteropServices;


namespace kutuphane_otomasyon
{
    public partial class KitapEkleFrm : Form
    {
        public KitapEkleFrm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-68O6AVP\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonDb;Integrated Security=True");

        bool durum;
        void mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where BarkodNo=@BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            SqlDataReader read = komut.ExecuteReader();

            if (read.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void KitapEkleFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            txtBarkodNo.Text = "";
            txtKitapAdi.Text = "";
            txtYazar.Text = "";
            txtYayınevi.Text = "";
            txtSayfaSayisi.Text = "";
            ComboTur.Text = "";
            txtStok.Text = "";
            txtRafNo.Text = "";
            comboDil.Text = "";
            txtAciklama.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kitap(BarkodNo,KitapAdı,Yazar,YayınEvi,SayfaSayısı,Tür,StokSayısı,RafNo,Dil,Açıklama,KayıtTarihi) values(@BarkodNo,@KitapAdı,@Yazar,@YayınEvi,@SayfaSayısı,@Tür,@StokSayısı,@RafNo,@Dil,@Açıklama,@KayıtTarihi)", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@KitapAdı", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@YayınEvi", txtYayınevi.Text);
                komut.Parameters.AddWithValue("@SayfaSayısı", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@Tür", ComboTur.Text);
                komut.Parameters.AddWithValue("@StokSayısı", txtStok.Text);
                komut.Parameters.AddWithValue("@RafNo", txtRafNo.Text);
                komut.Parameters.AddWithValue("@Dil", comboDil.Text);
                komut.Parameters.AddWithValue("@Açıklama", txtAciklama.Text);
                komut.Parameters.AddWithValue("@KayıtTarihi", DateTime.Now.ToShortDateString());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap Kaydedildi.");
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                comboDil.Text = "";
                ComboTur.Text = "";
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
