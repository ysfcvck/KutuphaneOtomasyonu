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


namespace kutuphane_otomasyon
{
    public partial class AnaSayfaFrm : Form
    {
        public AnaSayfaFrm()
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   // Anasayfa üye ekleme butonu.
        {
            UyeEkleFrm uyeekle = new UyeEkleFrm();
            uyeekle.Show();
        }

        private void AnaSayfaFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListelemeFrm uyeliste = new UyeListelemeFrm();
            uyeliste.Show();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleFrm kitapekle = new KitapEkleFrm();
            kitapekle.Show();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListeleFrm kitaplistele = new KitapListeleFrm();
            kitaplistele.Show();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVerFrm emanetkitapver = new EmanetKitapVerFrm();
            emanetkitapver.Show();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListeleFrm emanetlistele = new EmanetKitapListeleFrm();
            emanetlistele.Show();
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            EmanetKitapİadeFrm iade = new EmanetKitapİadeFrm();
            iade.Show();
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            SıralamaFrm sırala = new SıralamaFrm();
            sırala.Show();
        }

       

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            GirisFrm giris = new GirisFrm();
            giris.Show();
            this.Close();
            
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
