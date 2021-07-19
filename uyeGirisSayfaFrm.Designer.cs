
namespace kutuphane_otomasyon
{
    partial class uyeGirisSayfaFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeGirisSayfaFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKucult = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnSiralama = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.btnKucult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnKucult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnKucult.ImageIndex = 0;
            this.btnKucult.ImageList = this.ımageList2;
            this.btnKucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKucult.Location = new System.Drawing.Point(710, 4);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(23, 23);
            this.btnKucult.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnKucult, "Simge Durumuna Küçült");
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "_.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Listeler ve Sıralamalar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(739, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Uygulamayı Kapat");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.png");
            this.ımageList1.Images.SetKeyName(1, "listedenKaldır.png");
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnKitapListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitapListele.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btnKitapListele.ForeColor = System.Drawing.Color.Khaki;
            this.btnKitapListele.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKitapListele.Location = new System.Drawing.Point(228, 162);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(169, 26);
            this.btnKitapListele.TabIndex = 2;
            this.btnKitapListele.Text = "Kitap Listesi";
            this.btnKitapListele.UseVisualStyleBackColor = false;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnEmanetListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmanetListele.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btnEmanetListele.ForeColor = System.Drawing.Color.Khaki;
            this.btnEmanetListele.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEmanetListele.Location = new System.Drawing.Point(228, 121);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(169, 26);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Kitaplarım";
            this.btnEmanetListele.UseVisualStyleBackColor = false;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnSiralama
            // 
            this.btnSiralama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSiralama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiralama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiralama.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btnSiralama.ForeColor = System.Drawing.Color.Khaki;
            this.btnSiralama.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSiralama.Location = new System.Drawing.Point(228, 344);
            this.btnSiralama.Name = "btnSiralama";
            this.btnSiralama.Size = new System.Drawing.Size(169, 26);
            this.btnSiralama.TabIndex = 3;
            this.btnSiralama.Text = "Sıralama";
            this.btnSiralama.UseVisualStyleBackColor = false;
            this.btnSiralama.Click += new System.EventHandler(this.btnSiralama_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeri.ImageIndex = 1;
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(709, 434);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(50, 50);
            this.btnGeri.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnGeri, "Giriş Sayfasına Dön");
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(54, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 1);
            this.panel2.TabIndex = 8;
            // 
            // uyeGirisSayfaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.btnEmanetListele);
            this.Controls.Add(this.btnSiralama);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uyeGirisSayfaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyeGirisSayfaFrm";
            this.Load += new System.EventHandler(this.uyeGirisSayfaFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnSiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
    }
}