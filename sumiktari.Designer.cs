namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    partial class sumiktari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sumiktari));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblToplamSu = new System.Windows.Forms.Label();
            this.btnSuEkle = new Guna.UI2.WinForms.Guna2Button();
            this.txtSuMiktari = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartSuGecmisi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Panel2.Controls.Add(this.lblToplamSu);
            this.Panel2.Controls.Add(this.btnSuEkle);
            this.Panel2.Controls.Add(this.txtSuMiktari);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Location = new System.Drawing.Point(116, 66);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(394, 322);
            this.Panel2.TabIndex = 2;
            // 
            // lblToplamSu
            // 
            this.lblToplamSu.AutoSize = true;
            this.lblToplamSu.Location = new System.Drawing.Point(153, 253);
            this.lblToplamSu.Name = "lblToplamSu";
            this.lblToplamSu.Size = new System.Drawing.Size(44, 16);
            this.lblToplamSu.TabIndex = 8;
            this.lblToplamSu.Text = "label2";
            // 
            // btnSuEkle
            // 
            this.btnSuEkle.Animated = true;
            this.btnSuEkle.AutoRoundedCorners = true;
            this.btnSuEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnSuEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnSuEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSuEkle.ForeColor = System.Drawing.Color.White;
            this.btnSuEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnSuEkle.Image")));
            this.btnSuEkle.Location = new System.Drawing.Point(80, 177);
            this.btnSuEkle.Name = "btnSuEkle";
            this.btnSuEkle.Size = new System.Drawing.Size(209, 51);
            this.btnSuEkle.TabIndex = 7;
            this.btnSuEkle.Text = "Ekle";
            this.btnSuEkle.Click += new System.EventHandler(this.btnSuEkle_Click);
            // 
            // txtSuMiktari
            // 
            this.txtSuMiktari.Animated = true;
            this.txtSuMiktari.AutoRoundedCorners = true;
            this.txtSuMiktari.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSuMiktari.BorderColor = System.Drawing.Color.White;
            this.txtSuMiktari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuMiktari.DefaultText = "";
            this.txtSuMiktari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSuMiktari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSuMiktari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSuMiktari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSuMiktari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtSuMiktari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSuMiktari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSuMiktari.ForeColor = System.Drawing.Color.White;
            this.txtSuMiktari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSuMiktari.Location = new System.Drawing.Point(80, 93);
            this.txtSuMiktari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSuMiktari.Name = "txtSuMiktari";
            this.txtSuMiktari.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSuMiktari.PlaceholderText = "";
            this.txtSuMiktari.SelectedText = "";
            this.txtSuMiktari.Size = new System.Drawing.Size(229, 48);
            this.txtSuMiktari.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÜGÜN KAÇ LİTRE SU İÇTİN";
            // 
            // chartSuGecmisi
            // 
            this.chartSuGecmisi.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartSuGecmisi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSuGecmisi.Legends.Add(legend1);
            this.chartSuGecmisi.Location = new System.Drawing.Point(516, 66);
            this.chartSuGecmisi.Name = "chartSuGecmisi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSuGecmisi.Series.Add(series1);
            this.chartSuGecmisi.Size = new System.Drawing.Size(475, 322);
            this.chartSuGecmisi.TabIndex = 3;
            this.chartSuGecmisi.Text = "chart1";
            this.chartSuGecmisi.Click += new System.EventHandler(this.chartSuGecmisi_Click);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(604, 451);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangic.TabIndex = 4;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(604, 539);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 22);
            this.dtpBitis.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bittiş";
            // 
            // sumiktari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.chartSuGecmisi);
            this.Controls.Add(this.Panel2);
            this.Name = "sumiktari";
            this.Size = new System.Drawing.Size(994, 663);
            this.Load += new System.EventHandler(this.sumiktari_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuGecmisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2Button btnSuEkle;
        private Guna.UI2.WinForms.Guna2TextBox txtSuMiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamSu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuGecmisi;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
