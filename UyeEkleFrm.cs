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
using System.Runtime.InteropServices;


namespace kutuphane_otomasyon
{
    public partial class UyeEkleFrm : Form
    {
        public UyeEkleFrm()
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

        bool durum;

        void mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where TcNo=@TcNo", baglanti);
            komut.Parameters.AddWithValue("@TcNo", txtTc.Text);
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

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-68O6AVP\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonDb;Integrated Security=True");
        private void btnİptal_Click(object sender, EventArgs e)
        {
            txtTc.Text = "";
            txtAdSoyad.Text = "";
            txtYas.Text = "";
            comboCinsiyet.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into uye(TcNo,AdSoyad,Yaş,Cinsiyet,Telefon,Adres,ePosta,OkunanKitapSayısı,Sifre,GüvenlikKodu) values(@TcNo,@AdSoyad,@Yaş,@Cinsiyet,@Telefon,@Adres,@ePosta,@OkunanKitapSayısı,@Sifre,@GüvenlikKodu)", baglanti);

                string tckimlik;
                try
                {
                    tckimlik = txtTc.Text;
                    int index = 0;
                    int toplam = 0;
                    foreach (char n in tckimlik)
                    {
                        if (index < 10)
                        {
                            toplam += Convert.ToInt32(char.ToString(n));
                        }
                        index++;
                    }

                    if (toplam % 10 == Convert.ToInt32(tckimlik[10].ToString()))
                    {
                        Random rastgele = new Random();
                        int sayi = rastgele.Next(100000, 999999);
                        lblGuvenlik.Text = sayi.ToString();

                        komut.Parameters.AddWithValue("@TcNo", txtTc.Text);
                        komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@Yaş", txtYas.Text);
                        komut.Parameters.AddWithValue("@Cinsiyet", comboCinsiyet.Text);
                        komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                        komut.Parameters.AddWithValue("@ePosta", txtEmail.Text);
                        komut.Parameters.AddWithValue("@OkunanKitapSayısı", txtOkunanSayi.Text);
                        komut.Parameters.AddWithValue("@Sifre", txtTc.Text.Substring(7));
                        komut.Parameters.AddWithValue("@GüvenlikKodu", lblGuvenlik.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        comboCinsiyet.Text = "";
                        MessageBox.Show("Kayıt tamamlandı. " + "\n\n\n" + "* Şifre TC'nin son dört hanesi. " + "\n\n" + "* Güvenlik Kodu:" + lblGuvenlik.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                            {
                                if (item != txtOkunanSayi)
                                {
                                    item.Text = "";
                                }

                            }
                        }

                    }

                    else
                    {
                        MessageBox.Show("Geçersiz Tc Kimlik Numarası","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtTc.Text = "";
                    }
                }

                catch
                {
                    MessageBox.Show("Lütfen T.C. kimlik numarasını 11 hane olacak şekilde girin.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtTc.Text = "";
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UyeEkleFrm_Load(object sender, EventArgs e)
        {

            
            
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
