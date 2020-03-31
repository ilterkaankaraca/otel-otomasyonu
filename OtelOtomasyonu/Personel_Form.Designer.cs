namespace OtelOtomasyonu
{
    partial class Personel_Form
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
            this.listedatagrid = new System.Windows.Forms.DataGridView();
            this.yeni_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.durum_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yoneticiEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arama_textbox = new System.Windows.Forms.TextBox();
            this.ara_button = new System.Windows.Forms.Button();
            this.column_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listedatagrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listedatagrid
            // 
            this.listedatagrid.AllowUserToAddRows = false;
            this.listedatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listedatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listedatagrid.BackgroundColor = System.Drawing.Color.White;
            this.listedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listedatagrid.Location = new System.Drawing.Point(12, 29);
            this.listedatagrid.Name = "listedatagrid";
            this.listedatagrid.Size = new System.Drawing.Size(879, 371);
            this.listedatagrid.TabIndex = 0;
            this.listedatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listedatagrid_CellClick);
            // 
            // yeni_button
            // 
            this.yeni_button.Location = new System.Drawing.Point(12, 406);
            this.yeni_button.Name = "yeni_button";
            this.yeni_button.Size = new System.Drawing.Size(75, 23);
            this.yeni_button.TabIndex = 1;
            this.yeni_button.Text = "Yeni";
            this.yeni_button.UseVisualStyleBackColor = true;
            this.yeni_button.Click += new System.EventHandler(this.yeni_button_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.Location = new System.Drawing.Point(93, 406);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(75, 23);
            this.guncelle_button.TabIndex = 3;
            this.guncelle_button.Text = "Guncelle";
            this.guncelle_button.UseVisualStyleBackColor = true;
            this.guncelle_button.Visible = false;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // sil_button
            // 
            this.sil_button.Location = new System.Drawing.Point(174, 406);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(75, 23);
            this.sil_button.TabIndex = 4;
            this.sil_button.Text = "Sil";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Visible = false;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // durum_label
            // 
            this.durum_label.AutoSize = true;
            this.durum_label.Location = new System.Drawing.Point(791, 411);
            this.durum_label.Name = "durum_label";
            this.durum_label.Size = new System.Drawing.Size(0, 13);
            this.durum_label.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaListesiToolStripMenuItem,
            this.odaListesiToolStripMenuItem1,
            this.yoneticiEkranıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odaListesiToolStripMenuItem
            // 
            this.odaListesiToolStripMenuItem.Name = "odaListesiToolStripMenuItem";
            this.odaListesiToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.odaListesiToolStripMenuItem.Text = "Musteri Listesi";
            this.odaListesiToolStripMenuItem.Click += new System.EventHandler(this.odaListesiToolStripMenuItem_Click);
            // 
            // odaListesiToolStripMenuItem1
            // 
            this.odaListesiToolStripMenuItem1.Name = "odaListesiToolStripMenuItem1";
            this.odaListesiToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.odaListesiToolStripMenuItem1.Text = "Oda Listesi";
            this.odaListesiToolStripMenuItem1.Click += new System.EventHandler(this.odaListesiToolStripMenuItem1_Click);
            // 
            // yoneticiEkranıToolStripMenuItem
            // 
            this.yoneticiEkranıToolStripMenuItem.Name = "yoneticiEkranıToolStripMenuItem";
            this.yoneticiEkranıToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.yoneticiEkranıToolStripMenuItem.Text = "Yonetici Ekranı";
            this.yoneticiEkranıToolStripMenuItem.Visible = false;
            this.yoneticiEkranıToolStripMenuItem.Click += new System.EventHandler(this.yoneticiEkranıToolStripMenuItem_Click);
            // 
            // arama_textbox
            // 
            this.arama_textbox.Location = new System.Drawing.Point(752, 2);
            this.arama_textbox.Name = "arama_textbox";
            this.arama_textbox.Size = new System.Drawing.Size(100, 20);
            this.arama_textbox.TabIndex = 7;
            // 
            // ara_button
            // 
            this.ara_button.Location = new System.Drawing.Point(858, 0);
            this.ara_button.Name = "ara_button";
            this.ara_button.Size = new System.Drawing.Size(33, 23);
            this.ara_button.TabIndex = 8;
            this.ara_button.Text = "Ara";
            this.ara_button.UseVisualStyleBackColor = true;
            this.ara_button.Click += new System.EventHandler(this.ara_button_Click);
            // 
            // column_combobox
            // 
            this.column_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.column_combobox.FormattingEnabled = true;
            this.column_combobox.Location = new System.Drawing.Point(625, 1);
            this.column_combobox.Name = "column_combobox";
            this.column_combobox.Size = new System.Drawing.Size(121, 21);
            this.column_combobox.TabIndex = 9;
            // 
            // Personel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 441);
            this.Controls.Add(this.column_combobox);
            this.Controls.Add(this.ara_button);
            this.Controls.Add(this.arama_textbox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.durum_label);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.yeni_button);
            this.Controls.Add(this.listedatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Personel_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekrani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personel_Form_FormClosing);
            this.Load += new System.EventHandler(this.Personel_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listedatagrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listedatagrid;
        private System.Windows.Forms.Button yeni_button;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Label durum_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yoneticiEkranıToolStripMenuItem;
        private System.Windows.Forms.TextBox arama_textbox;
        private System.Windows.Forms.Button ara_button;
        private System.Windows.Forms.ComboBox column_combobox;
    }
}