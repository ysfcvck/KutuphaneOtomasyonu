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
    public partial class EmanetKitapListeleFrm : Form
    {
        public EmanetKitapListeleFrm()
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

        private void EmanetKitapListeleFrm_Load(object sender, EventArgs e)
        {
            emanetListele();
            kitapsayisi();
            comboBox1.SelectedIndex = 0;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;

        }

        private void emanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetKitaplar", baglanti);
            adtr.Fill(daset, "emanetKitaplar");
            dataGridView1.DataSource = daset.Tables["emanetKitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                emanetListele();
            }
            else if (comboBox1.SelectedIndex==1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetKitaplar where '"  + DateTime.Now.DayOfYear.ToString() + "' > Süre", baglanti);
                adtr.Fill(daset, "emanetKitaplar");
                dataGridView1.DataSource = daset.Tables["emanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetKitaplar where '"  + DateTime.Now.DayOfYear.ToString() +  "' <= Süre",  baglanti);
                adtr.Fill(daset, "emanetKitaplar");
                dataGridView1.DataSource = daset.Tables["emanetKitaplar"];
                baglanti.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
