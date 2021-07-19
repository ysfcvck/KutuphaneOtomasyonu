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
    public partial class uyeGirisSayfaFrm : Form
    {
        public uyeGirisSayfaFrm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            emanetKitapListeUyeFrm emanetKitapListe = new emanetKitapListeUyeFrm();
            emanetKitapListe.Show();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            kitapListeleUyeFrm kitapliste = new kitapListeleUyeFrm();
            kitapliste.Show();
        }        

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            sıralamaUyeFrm sırala = new sıralamaUyeFrm();
            sırala.Show();
        }
       
       

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFrm giris = new GirisFrm();
            giris.Show();
            this.Hide();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uyeGirisSayfaFrm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
