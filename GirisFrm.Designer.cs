
namespace kutuphane_otomasyon
{
    partial class GirisFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtKullanıcıAdıYonetici = new System.Windows.Forms.TextBox();
            this.txtSifreYonetici = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdıUye = new System.Windows.Forms.TextBox();
            this.txtSifreUye = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGirisYonetici = new System.Windows.Forms.Button();
            this.btnGirisUye = new System.Windows.Forms.Button();
            this.lnklblSifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSifre2 = new System.Windows.Forms.CheckBox();
            this.cbSifre1 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(256, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 300);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnKucult);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 53);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kütüphane Takip Sistemi Giriş Ekranı";
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.ForeColor = System.Drawing.Color.White;
            this.btnKucult.Location = new System.Drawing.Point(452, 12);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(28, 30);
            this.btnKucult.TabIndex = 4;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(486, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtKullanıcıAdıYonetici
            // 
            this.txtKullanıcıAdıYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txtKullanıcıAdıYonetici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullanıcıAdıYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdıYonetici.ForeColor = System.Drawing.Color.White;
            this.txtKullanıcıAdıYonetici.Location = new System.Drawing.Point(70, 219);
            this.txtKullanıcıAdıYonetici.Name = "txtKullanıcıAdıYonetici";
            this.txtKullanıcıAdıYonetici.Size = new System.Drawing.Size(135, 15);
            this.txtKullanıcıAdıYonetici.TabIndex = 8;
            this.txtKullanıcıAdıYonetici.Text = "Kullanıcı Adı";
            this.txtKullanıcıAdıYonetici.Click += new System.EventHandler(this.txtKullanıcıAdıYonetici_Click);
            // 
            // txtSifreYonetici
            // 
            this.txtSifreYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txtSifreYonetici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreYonetici.ForeColor = System.Drawing.Color.White;
            this.txtSifreYonetici.Location = new System.Drawing.Point(70, 265);
            this.txtSifreYonetici.Name = "txtSifreYonetici";
            this.txtSifreYonetici.Size = new System.Drawing.Size(135, 15);
            this.txtSifreYonetici.TabIndex = 9;
            this.txtSifreYonetici.Text = "Şifre";
            this.txtSifreYonetici.Click += new System.EventHandler(this.txtSifreYonetici_Click);
            this.txtSifreYonetici.Enter += new System.EventHandler(this.txtSifreYonetici_Enter);
            this.txtSifreYonetici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifreYonetici_KeyDown);
            // 
            // txtKullanıcıAdıUye
            // 
            this.txtKullanıcıAdıUye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txtKullanıcıAdıUye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullanıcıAdıUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdıUye.ForeColor = System.Drawing.Color.White;
            this.txtKullanıcıAdıUye.Location = new System.Drawing.Point(331, 221);
            this.txtKullanıcıAdıUye.Name = "txtKullanıcıAdıUye";
            this.txtKullanıcıAdıUye.Size = new System.Drawing.Size(135, 15);
            this.txtKullanıcıAdıUye.TabIndex = 11;
            this.txtKullanıcıAdıUye.Text = "Kullanıcı Adı";
            this.txtKullanıcıAdıUye.Click += new System.EventHandler(this.txtKullanıcıAdıUye_Click);
            this.txtKullanıcıAdıUye.TextChanged += new System.EventHandler(this.txtKullanıcıAdıUye_TextChanged);
            // 
            // txtSifreUye
            // 
            this.txtSifreUye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txtSifreUye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreUye.ForeColor = System.Drawing.Color.White;
            this.txtSifreUye.Location = new System.Drawing.Point(331, 265);
            this.txtSifreUye.Name = "txtSifreUye";
            this.txtSifreUye.Size = new System.Drawing.Size(135, 15);
            this.txtSifreUye.TabIndex = 12;
            this.txtSifreUye.Text = "Şifre";
            this.txtSifreUye.Click += new System.EventHandler(this.txtSifreUye_Click);
            this.txtSifreUye.TextChanged += new System.EventHandler(this.txtSifreUye_TextChanged);
            this.txtSifreUye.Enter += new System.EventHandler(this.txtSifreUye_Enter);
            this.txtSifreUye.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifreUye_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(70, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(70, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 1);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(331, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 1);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(331, 284);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 1);
            this.panel6.TabIndex = 15;
            // 
            // btnGirisYonetici
            // 
            this.btnGirisYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnGirisYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYonetici.BackgroundImage")));
            this.btnGirisYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirisYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYonetici.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYonetici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnGirisYonetici.Location = new System.Drawing.Point(161, 291);
            this.btnGirisYonetici.Name = "btnGirisYonetici";
            this.btnGirisYonetici.Size = new System.Drawing.Size(89, 39);
            this.btnGirisYonetici.TabIndex = 10;
            this.btnGirisYonetici.UseVisualStyleBackColor = false;
            this.btnGirisYonetici.Click += new System.EventHandler(this.btnGirisYonetici_Click);
            this.btnGirisYonetici.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGirisYonetici_MouseMove);
            // 
            // btnGirisUye
            // 
            this.btnGirisUye.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisUye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirisUye.BackgroundImage")));
            this.btnGirisUye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirisUye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisUye.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisUye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnGirisUye.Location = new System.Drawing.Point(419, 291);
            this.btnGirisUye.Name = "btnGirisUye";
            this.btnGirisUye.Size = new System.Drawing.Size(89, 39);
            this.btnGirisUye.TabIndex = 13;
            this.btnGirisUye.UseVisualStyleBackColor = false;
            this.btnGirisUye.Click += new System.EventHandler(this.btnGirisUye_Click);
            this.btnGirisUye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGirisUye_MouseMove);
            // 
            // lnklblSifreUnuttum
            // 
            this.lnklblSifreUnuttum.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lnklblSifreUnuttum.AutoSize = true;
            this.lnklblSifreUnuttum.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lnklblSifreUnuttum.Location = new System.Drawing.Point(332, 311);
            this.lnklblSifreUnuttum.Name = "lnklblSifreUnuttum";
            this.lnklblSifreUnuttum.Size = new System.Drawing.Size(81, 13);
            this.lnklblSifreUnuttum.TabIndex = 14;
            this.lnklblSifreUnuttum.TabStop = true;
            this.lnklblSifreUnuttum.Text = "Şifremi Unuttum";
            this.lnklblSifreUnuttum.VisitedLinkColor = System.Drawing.Color.White;
            this.lnklblSifreUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSifreUnuttum_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Yönetici Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(362, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Üye Girişi";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(300, 216);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(300, 260);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(39, 260);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::kutuphane_otomasyon.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(342, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kutuphane_otomasyon.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(90, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbSifre2
            // 
            this.cbSifre2.AutoSize = true;
            this.cbSifre2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSifre2.ForeColor = System.Drawing.Color.White;
            this.cbSifre2.Location = new System.Drawing.Point(331, 291);
            this.cbSifre2.Name = "cbSifre2";
            this.cbSifre2.Size = new System.Drawing.Size(89, 17);
            this.cbSifre2.TabIndex = 21;
            this.cbSifre2.Text = "Şifreyi Göster";
            this.cbSifre2.UseVisualStyleBackColor = true;
            this.cbSifre2.CheckedChanged += new System.EventHandler(this.cbSifre2_CheckedChanged);
            // 
            // cbSifre1
            // 
            this.cbSifre1.AutoSize = true;
            this.cbSifre1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSifre1.ForeColor = System.Drawing.Color.White;
            this.cbSifre1.Location = new System.Drawing.Point(70, 291);
            this.cbSifre1.Name = "cbSifre1";
            this.cbSifre1.Size = new System.Drawing.Size(89, 17);
            this.cbSifre1.TabIndex = 22;
            this.cbSifre1.Text = "Şifreyi Göster";
            this.cbSifre1.UseVisualStyleBackColor = true;
            this.cbSifre1.CheckedChanged += new System.EventHandler(this.cbSifre1_CheckedChanged);
            // 
            // GirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 385);
            this.Controls.Add(this.cbSifre1);
            this.Controls.Add(this.cbSifre2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnklblSifreUnuttum);
            this.Controls.Add(this.btnGirisUye);
            this.Controls.Add(this.btnGirisYonetici);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtSifreUye);
            this.Controls.Add(this.txtKullanıcıAdıUye);
            this.Controls.Add(this.txtSifreYonetici);
            this.Controls.Add(this.txtKullanıcıAdıYonetici);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtSifreYonetici;
        private System.Windows.Forms.TextBox txtSifreUye;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGirisYonetici;
        private System.Windows.Forms.Button btnGirisUye;
        private System.Windows.Forms.LinkLabel lnklblSifreUnuttum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullanıcıAdıYonetici;
        private System.Windows.Forms.CheckBox cbSifre2;
        private System.Windows.Forms.CheckBox cbSifre1;
        public System.Windows.Forms.TextBox txtKullanıcıAdıUye;
    }
}