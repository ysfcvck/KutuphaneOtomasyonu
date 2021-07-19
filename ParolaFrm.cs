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
    public partial class SifreFrm : Form
    {
        public SifreFrm()
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
            this.Close();
        }

        classKullanıcıFrm kullanıcıfrm = new classKullanıcıFrm();
        private void btnYeniSifre_Click(object sender, EventArgs e)
        {
            kullanıcıfrm.sifre(txtTcNo,txtGuvenlikKodu, txtSifre, txtSifreTekrar);
            txtTcNo.Text = "";
            txtSifreTekrar.Text = "";
            txtSifre.Text = "";
            txtGuvenlikKodu.Text = "";
            
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
