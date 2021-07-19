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
    public partial class SıralamaFrm : Form
    {
        public SıralamaFrm()
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
        private void SıralamaFrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye order by OkunanKitapSayısı desc", baglanti);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
           
            baglanti.Close();

            lblEnCokOku.Text = "";
            lblİkinci.Text = "";
            lblUcuncu.Text = "";
            lblEnCokOku.Text = daset.Tables["uye"].Rows[0]["AdSoyad"].ToString()  + "(";
            lblEnCokOku.Text += daset.Tables["uye"].Rows[0]["OkunanKitapSayısı"].ToString() + ")";
            lblİkinci.Text = daset.Tables["uye"].Rows[1]["AdSoyad"].ToString()  + "(";
            lblİkinci.Text += daset.Tables["uye"].Rows[1]["OkunanKitapSayısı"].ToString() + ")";
            lblUcuncu.Text = daset.Tables["uye"].Rows[2]["AdSoyad"].ToString()  + "(";
            lblUcuncu.Text += daset.Tables["uye"].Rows[2]["OkunanKitapSayısı"].ToString() + ")";
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
