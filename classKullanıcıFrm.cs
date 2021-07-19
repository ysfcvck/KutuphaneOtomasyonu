using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon
{
    class classKullanıcıFrm
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-68O6AVP\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonDb;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        uyeGirisSayfaFrm uyeGiris= new uyeGirisSayfaFrm();
        public SqlDataReader kullanıcı(TextBox kullanıcıadı,TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from uye where TcNo='"+kullanıcıadı.Text+"'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text==read["Sifre"].ToString())
                {                    
                    uyeGiris.Show();                  
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol edin", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol edin", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
            return read;

        }

        public void sifre(TextBox tcNo, TextBox güvenlikKodu, TextBox sifre, TextBox sifreTekrar)
        {
            if (sifre.Text==sifreTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from uye where TcNo='" + tcNo.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    if (güvenlikKodu.Text == read["GüvenlikKodu"].ToString())
                    {
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update uye set Sifre='"+sifre.Text+"' where TcNo='"+tcNo.Text+"'",baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Şifre değiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    }
                    else
                    {
                        MessageBox.Show("Bilgilerinizi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }            
            else
            {
                MessageBox.Show("Şifreyi doğru girdiğinizden emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
