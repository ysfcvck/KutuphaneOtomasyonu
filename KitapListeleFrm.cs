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
    public partial class KitapListeleFrm : Form
    {
        public KitapListeleFrm()
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


        private void kitapsayi()
        {
            int kayitsay;
            kayitsay = dataGridView1.RowCount - 1;
            lblKitap.Text = Convert.ToString(kayitsay);

        }
          private void stoksayi()
          {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            lblToplamKitap.Text = toplam.ToString();
          }
        

        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void KitapListeleFrm_Load(object sender, EventArgs e)
        {
            kitaplistele();
            kitapsayi();
            stoksayi();
            dataGridView1.Columns[9].Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Seçili kaydı silmek istiyor musun? ", "Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kitap where BarkodNo=@BarkodNo", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi !");
                daset.Tables["kitap"].Clear();
                comboDil.Text = "";
                ComboTur.Text = "";
                kitaplistele();
                kitapsayi();
                stoksayi();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set KitapAdı=@KitapAdı,Yazar=@Yazar,YayınEvi=@YayınEvi,SayfaSayısı=@SayfaSayısı,Tür=@Tür,StokSayısı=@StokSayısı,RafNo=@RafNo,Dil=@Dil,Açıklama=@Açıklama where BarkodNo=@BarkodNo", baglanti);
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
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıtlı Kitap Güncellendi !");
            daset.Tables["kitap"].Clear();
            kitaplistele();
            kitapsayi();
            stoksayi();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where BarkodNo like '%" + txtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
            kitapsayi();
            stoksayi();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where BarkodNo like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["KitapAdı"].ToString();
                txtYazar.Text = read["Yazar"].ToString();
                txtYayınevi.Text = read["YayınEvi"].ToString();
                txtSayfaSayisi.Text = read["SayfaSayısı"].ToString();
                ComboTur.Text = read["Tür"].ToString();
                txtStok.Text = read["StokSayısı"].ToString();
                txtRafNo.Text = read["RafNo"].ToString();
                comboDil.Text = read["Dil"].ToString();
                txtAciklama.Text = read["Açıklama"].ToString();
            }
            baglanti.Close();
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                comboDil.Text = "";
                ComboTur.Text = "";
            }
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // iptalButonu
            this.Close();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Açıklama"].Value.ToString();
        }
    }
}
