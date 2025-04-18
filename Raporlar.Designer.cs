using System;
using System.Windows.Forms;

namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    partial class Raporlar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRaporOlustur = new Guna.UI2.WinForms.Guna2Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dgvRaporlar = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Animated = true;
            this.btnRaporOlustur.AutoRoundedCorners = true;
            this.btnRaporOlustur.BackColor = System.Drawing.Color.Transparent;
            this.btnRaporOlustur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRaporOlustur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRaporOlustur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRaporOlustur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRaporOlustur.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRaporOlustur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRaporOlustur.ForeColor = System.Drawing.Color.White;
            this.btnRaporOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporOlustur.Image")));
            this.btnRaporOlustur.Location = new System.Drawing.Point(554, 273);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(209, 51);
            this.btnRaporOlustur.TabIndex = 9;
            this.btnRaporOlustur.Text = "Raporu İndir";
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "PDF Files (*.pdf)|*.pdf";
            // 
            // dgvRaporlar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRaporlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRaporlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRaporlar.ColumnHeadersHeight = 4;
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRaporlar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRaporlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRaporlar.Location = new System.Drawing.Point(3, 1);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.RowHeadersVisible = false;
            this.dgvRaporlar.RowHeadersWidth = 51;
            this.dgvRaporlar.RowTemplate.Height = 24;
            this.dgvRaporlar.Size = new System.Drawing.Size(988, 242);
            this.dgvRaporlar.TabIndex = 10;
            this.dgvRaporlar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRaporlar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRaporlar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRaporlar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRaporlar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRaporlar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRaporlar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRaporlar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRaporlar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRaporlar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvRaporlar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRaporlar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRaporlar.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvRaporlar.ThemeStyle.ReadOnly = false;
            this.dgvRaporlar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRaporlar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRaporlar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvRaporlar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRaporlar.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRaporlar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRaporlar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRaporlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaporlar_CellContentClick);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(39, 273);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(70, 16);
            this.lblKullaniciAdi.TabIndex = 11;
            this.lblKullaniciAdi.Text = "Ad Soyad:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(333, 273);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(91, 16);
            this.lblDogumTarihi.TabIndex = 12;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblTcKimlik);
            this.guna2Panel1.Controls.Add(this.dgvRaporlar);
            this.guna2Panel1.Controls.Add(this.lblDogumTarihi);
            this.guna2Panel1.Controls.Add(this.btnRaporOlustur);
            this.guna2Panel1.Controls.Add(this.lblKullaniciAdi);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(994, 663);
            this.guna2Panel1.TabIndex = 13;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Location = new System.Drawing.Point(186, 273);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(67, 16);
            this.lblTcKimlik.TabIndex = 13;
            this.lblTcKimlik.Text = "T.c Kimlik:";
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Raporlar";
            this.Size = new System.Drawing.Size(994, 663);
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        private void dgvRaporlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRaporOlustur;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRaporlar;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblTcKimlik;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
