using System;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chkPersonel = new System.Windows.Forms.CheckBox();
            this.chkHasta = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new Guna.UI2.WinForms.Guna2Button();
            this.txtTcKimlik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel1.BackgroundImage")));
            this.Panel1.Controls.Add(this.guna2ControlBox3);
            this.Panel1.Controls.Add(this.guna2ControlBox1);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(788, 761);
            this.Panel1.TabIndex = 0;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(671, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 13;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(726, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "KÜLTÜR SAĞLIK UYGULAMASI";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Panel2.Controls.Add(this.chkPersonel);
            this.Panel2.Controls.Add(this.chkHasta);
            this.Panel2.Controls.Add(this.linkLabel1);
            this.Panel2.Controls.Add(this.btnGiris);
            this.Panel2.Controls.Add(this.txtTcKimlik);
            this.Panel2.Controls.Add(this.txtSifre);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Location = new System.Drawing.Point(165, 108);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(417, 331);
            this.Panel2.TabIndex = 1;
            // 
            // chkPersonel
            // 
            this.chkPersonel.AutoSize = true;
            this.chkPersonel.Location = new System.Drawing.Point(151, 218);
            this.chkPersonel.Name = "chkPersonel";
            this.chkPersonel.Size = new System.Drawing.Size(86, 20);
            this.chkPersonel.TabIndex = 11;
            this.chkPersonel.Text = "Personel ";
            this.chkPersonel.UseVisualStyleBackColor = true;
            // 
            // chkHasta
            // 
            this.chkHasta.AutoSize = true;
            this.chkHasta.Location = new System.Drawing.Point(80, 218);
            this.chkHasta.Name = "chkHasta";
            this.chkHasta.Size = new System.Drawing.Size(65, 20);
            this.chkHasta.TabIndex = 9;
            this.chkHasta.Text = "Hasta";
            this.chkHasta.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(301, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.Animated = true;
            this.btnGiris.AutoRoundedCorners = true;
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(89, 244);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(209, 51);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Animated = true;
            this.txtTcKimlik.AutoRoundedCorners = true;
            this.txtTcKimlik.BackColor = System.Drawing.Color.SteelBlue;
            this.txtTcKimlik.BorderColor = System.Drawing.Color.White;
            this.txtTcKimlik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTcKimlik.DefaultText = "";
            this.txtTcKimlik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTcKimlik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTcKimlik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTcKimlik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTcKimlik.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtTcKimlik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTcKimlik.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTcKimlik.ForeColor = System.Drawing.Color.White;
            this.txtTcKimlik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTcKimlik.Location = new System.Drawing.Point(80, 63);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTcKimlik.PlaceholderText = "TC Kimlik Veya Kullanıcı Adı";
            this.txtTcKimlik.SelectedText = "";
            this.txtTcKimlik.Size = new System.Drawing.Size(229, 48);
            this.txtTcKimlik.TabIndex = 5;
            this.txtTcKimlik.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Animated = true;
            this.txtSifre.AutoRoundedCorners = true;
            this.txtSifre.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSifre.BorderColor = System.Drawing.Color.White;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultText = "";
            this.txtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSifre.Location = new System.Drawing.Point(80, 156);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(229, 48);
            this.txtSifre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ EKRANI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 761);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hasta Kayıt formunu aç
            HastaKayit hastaKayitForm = new HastaKayit();
            hastaKayitForm.Show();
            this.Hide(); 
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private System.Windows.Forms.CheckBox chkPersonel;
        private System.Windows.Forms.CheckBox chkHasta;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button btnGiris;
        private Guna.UI2.WinForms.Guna2TextBox txtTcKimlik;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

