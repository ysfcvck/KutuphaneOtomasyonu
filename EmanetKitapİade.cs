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
    public partial class EmanetKitapİadeFrm : Form
    {
        public EmanetKitapİadeFrm()
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


        private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(KitapSayısı) from emanetKitaplar", baglanti);
            lblKitapSay.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();

        }
        private void emanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetKitaplar", baglanti);
            adtr.Fill(daset, "emanetKitaplar");
            dataGridView1.DataSource = daset.Tables["emanetKitaplar"];
            baglanti.Close();
        }
        private void EmanetKitapİadeFrm_Load(object sender, EventArgs e)
        {
            emanetListele();
            kitapsayisi();
            dataGridView1.Columns[12].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e) 
            // Buton temizle
        {
            txtTcAra.Text = "";
            txtBarkodAra.Text = "";
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetKitaplar where TcNo like '%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetKitaplar");
            baglanti.Close();
            if (txtTcAra.Text=="")
            {
                daset.Tables["emanetKitaplar"].Clear();
                emanetListele();
                kitapsayisi();
            }

        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetKitaplar where BarkodNo like '%" + txtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetKitaplar");
            baglanti.Close();
            if (txtBarkodAra.Text == "")
            {
                daset.Tables["emanetKitaplar"].Clear();
                emanetListele();
                kitapsayisi();
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from emanetKitaplar where TcNo=@TcNo and BarkodNo=@BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@TcNo", dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString());
            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update kitap set StokSayısı=StokSayısı+'" + dataGridView1.CurrentRow.Cells["KitapSayısı"].Value.ToString() + "' where BarkodNo=@BarkodNo", baglanti);
            komut2.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap/lar iade edildi.");
            daset.Tables["emanetKitaplar"].Clear();
            emanetListele();
            kitapsayisi();
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