namespace KÜLTÜR_SAĞLIK_TAKİP_UYGULAMASI
{
    partial class EgzersizProgrami
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgzersizProgrami));
            this.cmbEgzersiz = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numSure = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtpTarih = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvEgzersizler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chartEgzersiz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgzersizler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEgzersiz)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEgzersiz
            // 
            this.cmbEgzersiz.BackColor = System.Drawing.Color.Transparent;
            this.cmbEgzersiz.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEgzersiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgzersiz.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEgzersiz.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEgzersiz.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEgzersiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEgzersiz.ItemHeight = 30;
            this.cmbEgzersiz.Items.AddRange(new object[] {
            "Koşu",
            "Yoga",
            "Ağırlık",
            "Kardiyo",
            "Esneklik"});
            this.cmbEgzersiz.Location = new System.Drawing.Point(759, 35);
            this.cmbEgzersiz.Name = "cmbEgzersiz";
            this.cmbEgzersiz.Size = new System.Drawing.Size(140, 36);
            this.cmbEgzersiz.TabIndex = 0;
            // 
            // numSure
            // 
            this.numSure.BackColor = System.Drawing.Color.Transparent;
            this.numSure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSure.Location = new System.Drawing.Point(785, 94);
            this.numSure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSure.Name = "numSure";
            this.numSure.Size = new System.Drawing.Size(114, 48);
            this.numSure.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Checked = true;
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTarih.Location = new System.Drawing.Point(657, 215);
            this.dtpTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(228, 36);
            this.dtpTarih.TabIndex = 2;
            this.dtpTarih.Value = new System.DateTime(2025, 3, 15, 7, 16, 17, 166);
            // 
            // dgvEgzersizler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEgzersizler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEgzersizler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEgzersizler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEgzersizler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEgzersizler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEgzersizler.Location = new System.Drawing.Point(62, 14);
            this.dgvEgzersizler.Name = "dgvEgzersizler";
            this.dgvEgzersizler.RowHeadersVisible = false;
            this.dgvEgzersizler.RowHeadersWidth = 51;
            this.dgvEgzersizler.RowTemplate.Height = 24;
            this.dgvEgzersizler.Size = new System.Drawing.Size(421, 237);
            this.dgvEgzersizler.TabIndex = 3;
            this.dgvEgzersizler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEgzersizler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEgzersizler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEgzersizler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEgzersizler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEgzersizler.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEgzersizler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEgzersizler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEgzersizler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEgzersizler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvEgzersizler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEgzersizler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgzersizler.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvEgzersizler.ThemeStyle.ReadOnly = false;
            this.dgvEgzersizler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEgzersizler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEgzersizler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvEgzersizler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEgzersizler.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEgzersizler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEgzersizler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // chartEgzersiz
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEgzersiz.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEgzersiz.Legends.Add(legend1);
            this.chartEgzersiz.Location = new System.Drawing.Point(62, 257);
            this.chartEgzersiz.Name = "chartEgzersiz";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEgzersiz.Series.Add(series1);
            this.chartEgzersiz.Size = new System.Drawing.Size(421, 262);
            this.chartEgzersiz.TabIndex = 4;
            this.chartEgzersiz.Text = "chartEgzersiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Egzersiz Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Egzersiz Süresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "En Son Hangi Gün Egzersiz Yaptın";
            // 
            // btnEkle
            // 
            this.btnEkle.Animated = true;
            this.btnEkle.AutoRoundedCorners = true;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(676, 281);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(209, 51);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // EgzersizProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartEgzersiz);
            this.Controls.Add(this.dgvEgzersizler);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.numSure);
            this.Controls.Add(this.cmbEgzersiz);
            this.Name = "EgzersizProgrami";
            this.Size = new System.Drawing.Size(994, 663);
            this.Load += new System.EventHandler(this.EgzersizProgrami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgzersizler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEgzersiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbEgzersiz;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSure;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTarih;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEgzersizler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEgzersiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
    }
}
