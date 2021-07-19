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
    public partial class EmanetKitapVerFrm : Form
    {
        public EmanetKitapVerFrm()
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
        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }

        private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(KitapSayısı) from sepet", baglanti);
            lblKitapSay.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();

        }

        private void EmanetKitapVerFrm_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayisi();
            dataGridView1.Columns[8].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int stokSayisi = Convert.ToInt32(lblStokSay.Text);
            int kitapSayisi = Convert.ToInt32(comboKitapSayi.Text);
           

            if (stokSayisi >= kitapSayisi)
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(BarkodNo,KitapAdı,Yazar,Yayınevi,SayfaSayısı,KitapSayısı,AlınanTarih,İadeTarihi,Süre) values(@BarkodNo,@KitapAdı,@Yazar,@Yayınevi,@SayfaSayısı,@KitapSayısı,@AlınanTarih,@İadeTarihi,@Süre)", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@KitapAdı", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
                komut.Parameters.AddWithValue("@SayfaSayısı", txtSayfaSayi.Text);
                komut.Parameters.AddWithValue("@KitapSayısı", int.Parse(comboKitapSayi.Text));
                komut.Parameters.AddWithValue("@AlınanTarih", dateTimePicker2.Text);
                komut.Parameters.AddWithValue("@İadeTarihi", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@Süre", dateTimePicker1.Value.DayOfYear);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap sepete eklendi.", "Ekleme İşlemi");
                daset.Tables["sepet"].Clear();
                sepetlistele();
                lblKitapSay.Text = "";
                kitapsayisi();

                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != comboKitapSayi)
                        {
                            item.Text = "";
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Stok yeterli değil!"+"\nStok Sayısı:"+lblStokSay.Text,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where TcNo like '" + txtTcAra.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtEposta.Text = read["ePosta"].ToString();
                txtTelefon.Text = read["Telefon"].ToString();
                txtYas.Text = read["Yaş"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(KitapSayısı) from emanetKitaplar where TcNo= '"+txtTcAra.Text+"'", baglanti);
            lblKayitliKitapSay.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txtTcAra.Text=="")
            {
                foreach (Control item in grpUyeBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                lblKayitliKitapSay.Text = "";
            }
        }
        
        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where BarkodNo like '"+txtBarkodNo.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["KitapAdı"].ToString();
                txtYazar.Text = read["Yazar"].ToString();
                txtYayınevi.Text = read["Yayınevi"].ToString();
                txtSayfaSayi.Text = read["SayfaSayısı"].ToString();
                lblStokSay.Text=read["StokSayısı"].ToString();
            }
            baglanti.Close();

            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != comboKitapSayi)
                        {
                            item.Text = "";
                        }
                    }
                }
                lblStokSay.Text = "";
                comboKitapSayi.Text = "";
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Seçili kitap sepetten çıkarılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sepetten çıkarıldı.", "Silme İşlemi");
                daset.Tables["sepet"].Clear();
                sepetlistele();
                lblKitapSay.Text = "";
                kitapsayisi();
            }
            
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSay.Text!="")
            {
                if (lblKayitliKitapSay.Text=="" && int.Parse(lblKitapSay.Text)<=3 || lblKayitliKitapSay.Text != "" && int.Parse(lblKayitliKitapSay.Text) + int.Parse(lblKitapSay.Text) <= 3)
                {
                    if (txtTcAra.Text != ""  &&  txtAdSoyad.Text != ""  &&  txtEposta.Text != ""  &&  txtTelefon.Text != ""  &&  txtYas.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into emanetKitaplar(TcNo,AdSoyad,Yaş,Telefon,BarkodNo,KitapAdı,Yazar,Yayınevi,SayfaSayısı,KitapSayısı,AlınanTarih,İadeTarihi,Süre) values(@TcNo,@AdSoyad,@Yaş,@Telefon,@BarkodNo,@KitapAdı,@Yazar,@Yayınevi,@SayfaSayısı,@KitapSayısı,@AlınanTarih,@İadeTarihi,@Süre)", baglanti);
                            komut.Parameters.AddWithValue("TcNo", txtTcAra.Text);
                            komut.Parameters.AddWithValue("AdSoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("Yaş", txtYas.Text);
                            komut.Parameters.AddWithValue("Telefon", txtTelefon.Text);
                            komut.Parameters.AddWithValue("BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapAdı", dataGridView1.Rows[i].Cells["KitapAdı"].Value.ToString());
                            komut.Parameters.AddWithValue("Yazar", dataGridView1.Rows[i].Cells["Yazar"].Value.ToString());
                            komut.Parameters.AddWithValue("Yayınevi", dataGridView1.Rows[i].Cells["Yayınevi"].Value.ToString());
                            komut.Parameters.AddWithValue("SayfaSayısı", dataGridView1.Rows[i].Cells["SayfaSayısı"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapSayısı", int.Parse(dataGridView1.Rows[i].Cells["KitapSayısı"].Value.ToString()));
                            komut.Parameters.AddWithValue("AlınanTarih", dataGridView1.Rows[i].Cells["AlınanTarih"].Value.ToString());
                            komut.Parameters.AddWithValue("İadeTarihi", dataGridView1.Rows[i].Cells["İadeTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("Süre", dataGridView1.Rows[i].Cells["Süre"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update uye set OkunanKitapSayısı = OkunanKitapSayısı + '" + int.Parse(dataGridView1.Rows[i].Cells["KitapSayısı"].Value.ToString())+"' where TcNo = '"+txtTcAra.Text+"' ",baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update kitap set StokSayısı = StokSayısı - '" + int.Parse(dataGridView1.Rows[i].Cells["KitapSayısı"].Value.ToString()) + "' where BarkodNo = '" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "' ", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap(lar) emanet edildi.");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txtTcAra.Text = "";

                        lblKitapSay.Text = "";
                        kitapsayisi();
                        lblKayitliKitapSay.Text = "";
                        //komut satırları
                    }
                    else
                    {
                        MessageBox.Show("Üye ismi seçmeniz gerekir !", "Uyarı");
                    }


                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz !", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Sepete kitap eklenmeli.", "Uyarı");
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
