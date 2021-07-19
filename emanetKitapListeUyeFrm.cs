using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace kutuphane_otomasyon
{
    public partial class emanetKitapListeUyeFrm : Form
    {
        public emanetKitapListeUyeFrm()
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetKitaplar where TcNo like '%" + GirisFrm.emanetTc + "%'", baglanti);
            adtr.Fill(daset, "emanetKitaplar");
            dataGridView1.DataSource = daset.Tables["emanetKitaplar"];
            baglanti.Close();
        }
        private void emanetKitapListeUyeFrm_Load(object sender, EventArgs e)
        {
            emanetListele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[12].Visible = false;
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
