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
    public partial class GirisFrm : Form
    {
        public GirisFrm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lnklblSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreFrm sifre = new SifreFrm();
            sifre.ShowDialog();
        }

        int hak = 3;
        private void btnGirisYonetici_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdıYonetici.Text == "" || txtSifreYonetici.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtKullanıcıAdıYonetici.Text == "admin" && txtSifreYonetici.Text == "password")
                {
                    AnaSayfaFrm frm = new AnaSayfaFrm();
                    frm.Show();
                    this.Hide();
                }
                else if (txtKullanıcıAdıYonetici.Text == "Kullanıcı Adı")
                {
                    MessageBox.Show("Lütfen bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSifreYonetici.Text == "Şifre")
                {
                    MessageBox.Show("Lütfen bir şifre girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    hak--;
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış! Kalan Hakkınız : " + hak, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (hak == 0)
                    {
                        MessageBox.Show("Çok fazla hatalı giriş yapıldı.\nUygulamadan Çıkılıyor...", "Çıkılıyor..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-68O6AVP\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonDb;Integrated Security=True");

        classKullanıcıFrm sınıf = new classKullanıcıFrm();



        public static string emanetTc;


        private void btnGirisUye_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where TcNo like '" + txtKullanıcıAdıUye.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            emanetTc = txtKullanıcıAdıUye.Text;

            if (read.Read() == true)
            {
                if (txtSifreUye.Text == read["Sifre"].ToString())
                {
                    this.Hide();
                }
            }
            baglanti.Close();
            sınıf.kullanıcı(txtKullanıcıAdıUye, txtSifreUye);
        }

        private void txtKullanıcıAdıYonetici_Click(object sender, EventArgs e)
        {
            txtKullanıcıAdıYonetici.Text = "";
            if (txtKullanıcıAdıUye.Text == "")
            {
                txtKullanıcıAdıUye.Text = "Kullanıcı Adı";
            }
        }
        private void txtSifreYonetici_Click(object sender, EventArgs e)
        {
            txtSifreYonetici.Text = "";
            if (txtKullanıcıAdıYonetici.Text == "")
            {
                txtKullanıcıAdıYonetici.Text = "Kullanıcı Adı";
            }
            if (txtKullanıcıAdıUye.Text == "")
            {
                txtKullanıcıAdıUye.Text = "Kullanıcı Adı";
            }
        }
        private void txtKullanıcıAdıUye_Click(object sender, EventArgs e)
        {
            txtKullanıcıAdıUye.Text = "";
            if (txtKullanıcıAdıYonetici.Text == "")
            {
                txtKullanıcıAdıYonetici.Text = "Kullanıcı Adı";
            }
        }
        private void txtSifreUye_Click(object sender, EventArgs e)
        {
            txtSifreUye.Text = "";

            if (txtKullanıcıAdıYonetici.Text == "")
            {
                txtKullanıcıAdıYonetici.Text = "Kullanıcı Adı";
            }
            if (txtKullanıcıAdıUye.Text == "")
            {
                txtKullanıcıAdıUye.Text = "Kullanıcı Adı";
            }
        }
        private void txtSifreYonetici_Enter(object sender, EventArgs e)
        {
            txtSifreYonetici.UseSystemPasswordChar = true;
        }

        private void txtSifreUye_Enter(object sender, EventArgs e)
        {
            txtSifreUye.UseSystemPasswordChar = true;
        }

        private void cbSifre1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifre1.CheckState == CheckState.Checked)
            {
                txtSifreYonetici.UseSystemPasswordChar = false;
            }
            else if (cbSifre1.CheckState == CheckState.Unchecked)
            {
                txtSifreYonetici.UseSystemPasswordChar = true;
            }
        }

        private void cbSifre2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifre2.CheckState == CheckState.Checked)
            {
                txtSifreUye.UseSystemPasswordChar = false;
            }
            else if (cbSifre2.CheckState == CheckState.Unchecked)
            {
                txtSifreUye.UseSystemPasswordChar = true;
            }
        }

        private void txtSifreYonetici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnGirisYonetici_Click(this, new EventArgs());
            }
        }

        private void txtSifreUye_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnGirisUye_Click(this, new EventArgs());
            }
        }

        private void btnGirisYonetici_MouseMove(object sender, MouseEventArgs e)
        {
            btnGirisYonetici.BackColor = Color.FromArgb(23, 23, 23);
        }

        private void btnGirisUye_MouseMove(object sender, MouseEventArgs e)
        {
            btnGirisUye.BackColor = Color.FromArgb(23, 23, 23);
        }

        private void txtKullanıcıAdıUye_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifreUye_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
