namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    partial class SaglikKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaglikKayit));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKaan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGiris = new Guna.UI2.WinForms.Guna2Button();
            this.txtKilo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNabiz = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoy = new Guna.UI2.WinForms.Guna2TextBox();
            this.geri = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.geri);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtKaan);
            this.guna2Panel1.Controls.Add(this.btnGiris);
            this.guna2Panel1.Controls.Add(this.txtKilo);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtNabiz);
            this.guna2Panel1.Controls.Add(this.txtBoy);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(865, 735);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(387, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Örnek:120/80 mmHg";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKaan
            // 
            this.txtKaan.Animated = true;
            this.txtKaan.AutoRoundedCorners = true;
            this.txtKaan.BackColor = System.Drawing.Color.SteelBlue;
            this.txtKaan.BorderColor = System.Drawing.Color.White;
            this.txtKaan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKaan.DefaultText = "";
            this.txtKaan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKaan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKaan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKaan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKaan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtKaan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKaan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKaan.ForeColor = System.Drawing.Color.Black;
            this.txtKaan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKaan.Location = new System.Drawing.Point(357, 232);
            this.txtKaan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKaan.Name = "txtKaan";
            this.txtKaan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtKaan.PlaceholderText = "KanBasinci";
            this.txtKaan.SelectedText = "";
            this.txtKaan.Size = new System.Drawing.Size(220, 48);
            this.txtKaan.TabIndex = 16;
            this.txtKaan.TextChanged += new System.EventHandler(this.txtKaan_TextChanged);
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
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(87, 351);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(470, 51);
            this.btnGiris.TabIndex = 15;
            this.btnGiris.Text = "Sağlık Bilgilerini Ekle";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKilo
            // 
            this.txtKilo.Animated = true;
            this.txtKilo.AutoRoundedCorners = true;
            this.txtKilo.BackColor = System.Drawing.Color.SteelBlue;
            this.txtKilo.BorderColor = System.Drawing.Color.White;
            this.txtKilo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKilo.DefaultText = "";
            this.txtKilo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKilo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKilo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKilo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKilo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtKilo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKilo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKilo.ForeColor = System.Drawing.Color.Black;
            this.txtKilo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKilo.Location = new System.Drawing.Point(357, 143);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtKilo.PlaceholderText = "Kilo";
            this.txtKilo.SelectedText = "";
            this.txtKilo.Size = new System.Drawing.Size(220, 48);
            this.txtKilo.TabIndex = 14;
            this.txtKilo.TextChanged += new System.EventHandler(this.txtKilo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "KÜLTÜR SAĞLIK UYGULAMASI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(261, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAĞLIK BİLGİLERİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNabiz
            // 
            this.txtNabiz.Animated = true;
            this.txtNabiz.AutoRoundedCorners = true;
            this.txtNabiz.BackColor = System.Drawing.Color.SteelBlue;
            this.txtNabiz.BorderColor = System.Drawing.Color.White;
            this.txtNabiz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNabiz.DefaultText = "";
            this.txtNabiz.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNabiz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNabiz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNabiz.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNabiz.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtNabiz.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNabiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNabiz.ForeColor = System.Drawing.Color.Black;
            this.txtNabiz.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNabiz.Location = new System.Drawing.Point(107, 143);
            this.txtNabiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNabiz.Name = "txtNabiz";
            this.txtNabiz.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNabiz.PlaceholderText = "Nabız";
            this.txtNabiz.SelectedText = "";
            this.txtNabiz.Size = new System.Drawing.Size(220, 48);
            this.txtNabiz.TabIndex = 5;
            this.txtNabiz.TextChanged += new System.EventHandler(this.txtNabiz_TextChanged);
            // 
            // txtBoy
            // 
            this.txtBoy.Animated = true;
            this.txtBoy.AutoRoundedCorners = true;
            this.txtBoy.BackColor = System.Drawing.Color.SteelBlue;
            this.txtBoy.BorderColor = System.Drawing.Color.White;
            this.txtBoy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoy.DefaultText = "";
            this.txtBoy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtBoy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoy.ForeColor = System.Drawing.Color.Black;
            this.txtBoy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoy.Location = new System.Drawing.Point(107, 232);
            this.txtBoy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBoy.PlaceholderText = "Boy";
            this.txtBoy.SelectedText = "";
            this.txtBoy.Size = new System.Drawing.Size(220, 48);
            this.txtBoy.TabIndex = 6;
            this.txtBoy.TextChanged += new System.EventHandler(this.txtBoy_TextChanged);
            // 
            // geri
            // 
            this.geri.Animated = true;
            this.geri.AutoRoundedCorners = true;
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.geri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.geri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.geri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.geri.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.geri.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.geri.ForeColor = System.Drawing.Color.Black;
            this.geri.Image = ((System.Drawing.Image)(resources.GetObject("geri.Image")));
            this.geri.Location = new System.Drawing.Point(266, 451);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(126, 120);
            this.geri.TabIndex = 18;
            this.geri.Text = "Geri Git";
            this.geri.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(745, 13);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 20;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(800, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 19;
            // 
            // SaglikKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 735);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaglikKayit";
            this.Text = "SaglikKayit";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtKilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNabiz;
        private Guna.UI2.WinForms.Guna2TextBox txtBoy;
        private Guna.UI2.WinForms.Guna2TextBox txtKaan;
        private Guna.UI2.WinForms.Guna2Button btnGiris;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button geri;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}