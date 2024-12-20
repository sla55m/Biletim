﻿using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Biletim
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biletim));
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            btnKapat = new Button();
            btnBiletDurumu = new Button();
            btnSeferDurumu = new Button();
            btnKampanyalar = new Button();
            btnSeferAra = new Button();
            btnKullanciGirisi = new Button();
            btnYeniKullanci = new Button();
            panelLogo = new Panel();
            LBBulunduSayfaAdi = new Label();
            panelUst = new Panel();
            btnBackSatisİcin = new Button();
            btrSakla = new Button();
            btnBackhizmet = new Button();
            btnGenisle = new Button();
            btnClose = new Button();
            panelFormlar = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogo.SuspendLayout();
            panelUst.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 49, 65);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnKapat);
            panelMenu.Controls.Add(btnBiletDurumu);
            panelMenu.Controls.Add(btnSeferDurumu);
            panelMenu.Controls.Add(btnKampanyalar);
            panelMenu.Controls.Add(btnSeferAra);
            panelMenu.Controls.Add(btnKullanciGirisi);
            panelMenu.Controls.Add(btnYeniKullanci);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(233, 929);
            panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnKapat
            // 
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Book Antiqua", 15.75F);
            btnKapat.ForeColor = SystemColors.ButtonFace;
            btnKapat.ImageAlign = ContentAlignment.MiddleLeft;
            btnKapat.Location = new Point(0, 680);
            btnKapat.Margin = new Padding(4, 3, 4, 3);
            btnKapat.Name = "btnKapat";
            btnKapat.Padding = new Padding(14, 0, 0, 0);
            btnKapat.Size = new Size(233, 70);
            btnKapat.TabIndex = 12;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnBiletDurumu
            // 
            btnBiletDurumu.FlatAppearance.BorderSize = 0;
            btnBiletDurumu.FlatStyle = FlatStyle.Flat;
            btnBiletDurumu.Font = new Font("Book Antiqua", 15.75F);
            btnBiletDurumu.ForeColor = SystemColors.ButtonFace;
            btnBiletDurumu.ImageAlign = ContentAlignment.MiddleLeft;
            btnBiletDurumu.Location = new Point(0, 620);
            btnBiletDurumu.Margin = new Padding(4, 3, 4, 3);
            btnBiletDurumu.Name = "btnBiletDurumu";
            btnBiletDurumu.Padding = new Padding(14, 0, 0, 0);
            btnBiletDurumu.Size = new Size(233, 70);
            btnBiletDurumu.TabIndex = 9;
            btnBiletDurumu.Text = "Bilet Durumu";
            btnBiletDurumu.UseVisualStyleBackColor = true;
            // 
            // btnSeferDurumu
            // 
            btnSeferDurumu.FlatAppearance.BorderSize = 0;
            btnSeferDurumu.FlatStyle = FlatStyle.Flat;
            btnSeferDurumu.Font = new Font("Book Antiqua", 15.75F);
            btnSeferDurumu.ForeColor = SystemColors.ButtonFace;
            btnSeferDurumu.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeferDurumu.Location = new Point(0, 550);
            btnSeferDurumu.Margin = new Padding(4, 3, 4, 3);
            btnSeferDurumu.Name = "btnSeferDurumu";
            btnSeferDurumu.Padding = new Padding(14, 0, 0, 0);
            btnSeferDurumu.Size = new Size(233, 70);
            btnSeferDurumu.TabIndex = 6;
            btnSeferDurumu.Text = "Sefer Durumu";
            btnSeferDurumu.UseVisualStyleBackColor = true;
            // 
            // btnKampanyalar
            // 
            btnKampanyalar.FlatAppearance.BorderSize = 0;
            btnKampanyalar.FlatStyle = FlatStyle.Flat;
            btnKampanyalar.Font = new Font("Book Antiqua", 15.75F);
            btnKampanyalar.ForeColor = SystemColors.ButtonFace;
            btnKampanyalar.ImageAlign = ContentAlignment.MiddleLeft;
            btnKampanyalar.Location = new Point(0, 480);
            btnKampanyalar.Margin = new Padding(4, 3, 4, 3);
            btnKampanyalar.Name = "btnKampanyalar";
            btnKampanyalar.Padding = new Padding(14, 0, 0, 0);
            btnKampanyalar.Size = new Size(233, 70);
            btnKampanyalar.TabIndex = 5;
            btnKampanyalar.Text = "Kampanyalar";
            btnKampanyalar.UseVisualStyleBackColor = true;
            btnKampanyalar.Click += btnKampanyalar_Click;
            // 
            // btnSeferAra
            // 
            btnSeferAra.FlatAppearance.BorderSize = 0;
            btnSeferAra.FlatStyle = FlatStyle.Flat;
            btnSeferAra.Font = new Font("Book Antiqua", 15.75F);
            btnSeferAra.ForeColor = SystemColors.ButtonFace;
            btnSeferAra.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeferAra.Location = new Point(0, 410);
            btnSeferAra.Margin = new Padding(4, 3, 4, 3);
            btnSeferAra.Name = "btnSeferAra";
            btnSeferAra.Padding = new Padding(14, 0, 0, 0);
            btnSeferAra.Size = new Size(233, 70);
            btnSeferAra.TabIndex = 4;
            btnSeferAra.Text = "Sefer Ara";
            btnSeferAra.UseVisualStyleBackColor = true;
            btnSeferAra.Click += btnSeferAra_Click;
            // 
            // btnKullanciGirisi
            // 
            btnKullanciGirisi.FlatAppearance.BorderSize = 0;
            btnKullanciGirisi.FlatStyle = FlatStyle.Flat;
            btnKullanciGirisi.Font = new Font("Book Antiqua", 15.75F);
            btnKullanciGirisi.ForeColor = SystemColors.ButtonFace;
            btnKullanciGirisi.ImageAlign = ContentAlignment.MiddleLeft;
            btnKullanciGirisi.Location = new Point(0, 340);
            btnKullanciGirisi.Margin = new Padding(4, 3, 4, 3);
            btnKullanciGirisi.Name = "btnKullanciGirisi";
            btnKullanciGirisi.Padding = new Padding(14, 0, 0, 0);
            btnKullanciGirisi.Size = new Size(233, 70);
            btnKullanciGirisi.TabIndex = 2;
            btnKullanciGirisi.Text = "Kullancı Girişi";
            btnKullanciGirisi.UseVisualStyleBackColor = true;
            btnKullanciGirisi.Click += btnKullanciGirisi_Click;
            // 
            // btnYeniKullanci
            // 
            btnYeniKullanci.FlatAppearance.BorderSize = 0;
            btnYeniKullanci.FlatStyle = FlatStyle.Flat;
            btnYeniKullanci.Font = new Font("Book Antiqua", 15.75F);
            btnYeniKullanci.ForeColor = SystemColors.ButtonFace;
            btnYeniKullanci.ImageAlign = ContentAlignment.MiddleLeft;
            btnYeniKullanci.Location = new Point(4, 277);
            btnYeniKullanci.Margin = new Padding(4, 3, 4, 3);
            btnYeniKullanci.Name = "btnYeniKullanci";
            btnYeniKullanci.Padding = new Padding(14, 0, 0, 0);
            btnYeniKullanci.Size = new Size(233, 70);
            btnYeniKullanci.TabIndex = 1;
            btnYeniKullanci.Text = "Yeni Kullancı Hesapı Oluştur";
            btnYeniKullanci.UseVisualStyleBackColor = true;
            btnYeniKullanci.Click += btnYeniKullanci_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 49, 65);
            panelLogo.Controls.Add(LBBulunduSayfaAdi);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 3, 4, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 48);
            panelLogo.TabIndex = 1;
            // 
            // LBBulunduSayfaAdi
            // 
            LBBulunduSayfaAdi.AutoSize = true;
            LBBulunduSayfaAdi.Font = new Font("Sakkal Majalla", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBBulunduSayfaAdi.ForeColor = SystemColors.ButtonFace;
            LBBulunduSayfaAdi.Location = new Point(5, 5);
            LBBulunduSayfaAdi.Margin = new Padding(4, 0, 4, 0);
            LBBulunduSayfaAdi.Name = "LBBulunduSayfaAdi";
            LBBulunduSayfaAdi.Size = new Size(68, 35);
            LBBulunduSayfaAdi.TabIndex = 2;
            LBBulunduSayfaAdi.Text = "Home";
            // 
            // panelUst
            // 
            panelUst.BackColor = Color.FromArgb(39, 49, 65);
            panelUst.Controls.Add(btnBackSatisİcin);
            panelUst.Controls.Add(btrSakla);
            panelUst.Controls.Add(btnBackhizmet);
            panelUst.Controls.Add(btnGenisle);
            panelUst.Controls.Add(btnClose);
            panelUst.Dock = DockStyle.Top;
            panelUst.Location = new Point(233, 0);
            panelUst.Margin = new Padding(4, 3, 4, 3);
            panelUst.Name = "panelUst";
            panelUst.Size = new Size(1691, 48);
            panelUst.TabIndex = 1;
            panelUst.Paint += panelUst_Paint;
            // 
            // btnBackSatisİcin
            // 
            btnBackSatisİcin.Dock = DockStyle.Left;
            btnBackSatisİcin.FlatAppearance.BorderSize = 0;
            btnBackSatisİcin.FlatStyle = FlatStyle.Flat;
            btnBackSatisİcin.Location = new Point(86, 0);
            btnBackSatisİcin.Margin = new Padding(4, 3, 4, 3);
            btnBackSatisİcin.Name = "btnBackSatisİcin";
            btnBackSatisİcin.Size = new Size(86, 48);
            btnBackSatisİcin.TabIndex = 1;
            btnBackSatisİcin.UseVisualStyleBackColor = true;
            btnBackSatisİcin.Visible = false;
            // 
            // btrSakla
            // 
            btrSakla.Dock = DockStyle.Right;
            btrSakla.FlatAppearance.BorderSize = 0;
            btrSakla.FlatStyle = FlatStyle.Flat;
            btrSakla.Location = new Point(1565, 0);
            btrSakla.Margin = new Padding(4, 3, 4, 3);
            btrSakla.Name = "btrSakla";
            btrSakla.Size = new Size(42, 48);
            btrSakla.TabIndex = 0;
            btrSakla.UseVisualStyleBackColor = true;
            // 
            // btnBackhizmet
            // 
            btnBackhizmet.Dock = DockStyle.Left;
            btnBackhizmet.FlatAppearance.BorderSize = 0;
            btnBackhizmet.FlatStyle = FlatStyle.Flat;
            btnBackhizmet.Location = new Point(0, 0);
            btnBackhizmet.Margin = new Padding(4, 3, 4, 3);
            btnBackhizmet.Name = "btnBackhizmet";
            btnBackhizmet.Size = new Size(86, 48);
            btnBackhizmet.TabIndex = 0;
            btnBackhizmet.UseVisualStyleBackColor = true;
            btnBackhizmet.Visible = false;
            // 
            // btnGenisle
            // 
            btnGenisle.Dock = DockStyle.Right;
            btnGenisle.FlatAppearance.BorderSize = 0;
            btnGenisle.FlatStyle = FlatStyle.Flat;
            btnGenisle.Location = new Point(1607, 0);
            btnGenisle.Margin = new Padding(4, 3, 4, 3);
            btnGenisle.Name = "btnGenisle";
            btnGenisle.Size = new Size(42, 48);
            btnGenisle.TabIndex = 1;
            btnGenisle.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1649, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 48);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panelFormlar
            // 
            panelFormlar.Dock = DockStyle.Fill;
            panelFormlar.Location = new Point(233, 48);
            panelFormlar.Margin = new Padding(4, 3, 4, 3);
            panelFormlar.Name = "panelFormlar";
            panelFormlar.Size = new Size(1691, 881);
            panelFormlar.TabIndex = 2;
            // 
            // Biletim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1924, 929);
            Controls.Add(panelFormlar);
            Controls.Add(panelUst);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Biletim";
            Text = "Biletim";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelUst.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnYeniKullanci;
        private System.Windows.Forms.Button btnKullanciGirisi;
        private System.Windows.Forms.Button btnSeferAra;
        private System.Windows.Forms.Button btnKampanyalar;
        private System.Windows.Forms.Button btnSeferDurumu;
        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label LBBulunduSayfaAdi;
        private System.Windows.Forms.Panel panelFormlar;
        private System.Windows.Forms.Button btnBackhizmet;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btrSakla;
        private System.Windows.Forms.Button btnGenisle;
        private System.Windows.Forms.Button btnBiletDurumu;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBackSatisİcin;
        private PictureBox pictureBox1;
    }
}