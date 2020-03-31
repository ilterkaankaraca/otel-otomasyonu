namespace OtelOtomasyonu
{
    partial class Yonetici_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Yeni_Personel_Button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.musteriDataSet1 = new OtelOtomasyonu.musteriDataSet();
            this.guncelle_buton = new System.Windows.Forms.Button();
            this.durum_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arama_textbox = new System.Windows.Forms.TextBox();
            this.ara_textbox = new System.Windows.Forms.Button();
            this.column_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(879, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Yeni_Personel_Button
            // 
            this.Yeni_Personel_Button.Location = new System.Drawing.Point(12, 406);
            this.Yeni_Personel_Button.Name = "Yeni_Personel_Button";
            this.Yeni_Personel_Button.Size = new System.Drawing.Size(75, 23);
            this.Yeni_Personel_Button.TabIndex = 1;
            this.Yeni_Personel_Button.Text = "Yeni";
            this.Yeni_Personel_Button.UseVisualStyleBackColor = true;
            this.Yeni_Personel_Button.Click += new System.EventHandler(this.Yeni_Personel_Button_Click);
            // 
            // sil_button
            // 
            this.sil_button.Location = new System.Drawing.Point(174, 406);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(75, 23);
            this.sil_button.TabIndex = 2;
            this.sil_button.Text = "Sil";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Visible = false;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // musteriDataSet1
            // 
            this.musteriDataSet1.DataSetName = "musteriDataSet";
            this.musteriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guncelle_buton
            // 
            this.guncelle_buton.Location = new System.Drawing.Point(93, 406);
            this.guncelle_buton.Name = "guncelle_buton";
            this.guncelle_buton.Size = new System.Drawing.Size(75, 23);
            this.guncelle_buton.TabIndex = 3;
            this.guncelle_buton.Text = "Guncelle";
            this.guncelle_buton.UseVisualStyleBackColor = true;
            this.guncelle_buton.Visible = false;
            this.guncelle_buton.Click += new System.EventHandler(this.guncelle_buton_Click);
            // 
            // durum_label
            // 
            this.durum_label.AutoSize = true;
            this.durum_label.Location = new System.Drawing.Point(701, 411);
            this.durum_label.Name = "durum_label";
            this.durum_label.Size = new System.Drawing.Size(0, 13);
            this.durum_label.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıBilgileriToolStripMenuItem,
            this.girisToolStripMenuItem,
            this.personelEkranıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // girisToolStripMenuItem
            // 
            this.girisToolStripMenuItem.Name = "girisToolStripMenuItem";
            this.girisToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.girisToolStripMenuItem.Text = "Loglar";
            this.girisToolStripMenuItem.Click += new System.EventHandler(this.girisToolStripMenuItem_Click);
            // 
            // personelEkranıToolStripMenuItem
            // 
            this.personelEkranıToolStripMenuItem.Name = "personelEkranıToolStripMenuItem";
            this.personelEkranıToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.personelEkranıToolStripMenuItem.Text = "Personel Ekranı";
            this.personelEkranıToolStripMenuItem.Click += new System.EventHandler(this.personelEkranıToolStripMenuItem_Click);
            // 
            // arama_textbox
            // 
            this.arama_textbox.Location = new System.Drawing.Point(736, 4);
            this.arama_textbox.Name = "arama_textbox";
            this.arama_textbox.Size = new System.Drawing.Size(100, 20);
            this.arama_textbox.TabIndex = 7;
            // 
            // ara_textbox
            // 
            this.ara_textbox.Location = new System.Drawing.Point(842, 2);
            this.ara_textbox.Name = "ara_textbox";
            this.ara_textbox.Size = new System.Drawing.Size(49, 23);
            this.ara_textbox.TabIndex = 8;
            this.ara_textbox.Text = "Ara";
            this.ara_textbox.UseVisualStyleBackColor = true;
            this.ara_textbox.Click += new System.EventHandler(this.ara_textbox_Click);
            // 
            // column_combobox
            // 
            this.column_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.column_combobox.FormattingEnabled = true;
            this.column_combobox.Location = new System.Drawing.Point(609, 4);
            this.column_combobox.Name = "column_combobox";
            this.column_combobox.Size = new System.Drawing.Size(121, 21);
            this.column_combobox.TabIndex = 9;
            // 
            // Yonetici_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 441);
            this.Controls.Add(this.column_combobox);
            this.Controls.Add(this.ara_textbox);
            this.Controls.Add(this.arama_textbox);
            this.Controls.Add(this.durum_label);
            this.Controls.Add(this.guncelle_buton);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.Yeni_Personel_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Yonetici_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yonetici Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yonetici_Form_FormClosing);
            this.Load += new System.EventHandler(this.Yonetici_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Yeni_Personel_Button;
        private System.Windows.Forms.Button sil_button;
        private musteriDataSet musteriDataSet1;
        private System.Windows.Forms.Button guncelle_buton;
        private System.Windows.Forms.Label durum_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkranıToolStripMenuItem;
        private System.Windows.Forms.TextBox arama_textbox;
        private System.Windows.Forms.Button ara_textbox;
        private System.Windows.Forms.ComboBox column_combobox;
    }
}