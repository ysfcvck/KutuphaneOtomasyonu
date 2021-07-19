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
    public partial class UyeListelemeFrm : Form
    {
        public UyeListelemeFrm()
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString();
        }

        private void uyesayisi()
        {
            int kayitsay;
            kayitsay = dataGridView1.RowCount - 1;
            lblUyeSayi.Text = Convert.ToString(kayitsay);

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where TcNo like '"+txtTc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtYas.Text = read["Yaş"].ToString();
                comboCinsiyet.Text = read["Cinsiyet"].ToString();
                txtTelefon.Text = read["Telefon"].ToString();
                txtAdres.Text = read["Adres"].ToString();
                txtEmail.Text = read["ePosta"].ToString();
                txtOkunanSayi.Text = read["OkunanKitapSayısı"].ToString();
                
            }
            baglanti.Close();

            if (txtTc.Text=="")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = ""; 
                    }
                }
                comboCinsiyet.Text= "";
            }
        }


        DataSet daset = new DataSet();
        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where TcNo like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
            uyesayisi();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Seçili kaydı silmek istiyor musun? ","Kaydı Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where TcNo=@TcNo", baglanti);
                komut.Parameters.AddWithValue("@TcNo", dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi !");
                daset.Tables["uye"].Clear();
                comboCinsiyet.Text = "";
                uyelistele();
                uyesayisi();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            
        }

        private void uyelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye", baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void UyeListelemeFrm_Load(object sender, EventArgs e)
        {
            uyelistele();
            uyesayisi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                MessageBox.Show("Lütfen TC No Girin","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update uye set AdSoyad=@AdSoyad,Yaş=@Yaş,Cinsiyet=@Cinsiyet,Telefon=@Telefon,Adres=@Adres,ePosta=@ePosta,OkunanKitapSayısı=@OkunanKitapSayısı where TcNo=@TcNo", baglanti);
                komut.Parameters.AddWithValue("@TcNo", txtTc.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@Yaş", txtYas.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@ePosta", txtEmail.Text);
                komut.Parameters.AddWithValue("@OkunanKitapSayısı", int.Parse(txtOkunanSayi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıtlı Üye Güncellendi !");
                daset.Tables["uye"].Clear();
                uyelistele();
                uyesayisi();

                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
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
