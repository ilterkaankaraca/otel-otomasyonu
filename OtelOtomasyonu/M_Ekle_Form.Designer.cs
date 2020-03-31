namespace OtelOtomasyonu
{
    partial class M_Ekle_Form
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
            this.ad_text = new System.Windows.Forms.TextBox();
            this.tcno_text = new System.Windows.Forms.TextBox();
            this.soyad_text = new System.Windows.Forms.TextBox();
            this.telno_text = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.tcno = new System.Windows.Forms.Label();
            this.telno = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Label();
            this.giris_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kaydet = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.oda_combobox = new System.Windows.Forms.ComboBox();
            this.oda_label = new System.Windows.Forms.Label();
            this.durum_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ad_text
            // 
            this.ad_text.Location = new System.Drawing.Point(127, 26);
            this.ad_text.Name = "ad_text";
            this.ad_text.Size = new System.Drawing.Size(200, 20);
            this.ad_text.TabIndex = 1;
            this.ad_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_text_KeyPress);
            // 
            // tcno_text
            // 
            this.tcno_text.Location = new System.Drawing.Point(127, 78);
            this.tcno_text.Name = "tcno_text";
            this.tcno_text.Size = new System.Drawing.Size(200, 20);
            this.tcno_text.TabIndex = 3;
            this.tcno_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_text_KeyPress);
            // 
            // soyad_text
            // 
            this.soyad_text.Location = new System.Drawing.Point(127, 52);
            this.soyad_text.Name = "soyad_text";
            this.soyad_text.Size = new System.Drawing.Size(200, 20);
            this.soyad_text.TabIndex = 2;
            this.soyad_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_text_KeyPress);
            // 
            // telno_text
            // 
            this.telno_text.Location = new System.Drawing.Point(127, 104);
            this.telno_text.Name = "telno_text";
            this.telno_text.Size = new System.Drawing.Size(200, 20);
            this.telno_text.TabIndex = 4;
            this.telno_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_text_KeyPress);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(12, 29);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(22, 13);
            this.ad.TabIndex = 7;
            this.ad.Text = "Adı";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(10, 55);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(39, 13);
            this.soyad.TabIndex = 8;
            this.soyad.Text = "Soyadi";
            // 
            // tcno
            // 
            this.tcno.AutoSize = true;
            this.tcno.Location = new System.Drawing.Point(10, 81);
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(101, 13);
            this.tcno.TabIndex = 9;
            this.tcno.Text = "T.C Kimlik Numarasi";
            // 
            // telno
            // 
            this.telno.AutoSize = true;
            this.telno.Location = new System.Drawing.Point(12, 107);
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(90, 13);
            this.telno.TabIndex = 10;
            this.telno.Text = "Telefon Numarasi";
            // 
            // giris
            // 
            this.giris.AutoSize = true;
            this.giris.Location = new System.Drawing.Point(12, 136);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(56, 13);
            this.giris.TabIndex = 11;
            this.giris.Text = "Giris Tarihi";
            // 
            // giris_dateTimePicker
            // 
            this.giris_dateTimePicker.Location = new System.Drawing.Point(127, 130);
            this.giris_dateTimePicker.Name = "giris_dateTimePicker";
            this.giris_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.giris_dateTimePicker.TabIndex = 5;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(13, 223);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 23);
            this.kaydet.TabIndex = 16;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // iptal
            // 
            this.iptal.Location = new System.Drawing.Point(94, 223);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(75, 23);
            this.iptal.TabIndex = 17;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = true;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // oda_combobox
            // 
            this.oda_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oda_combobox.FormattingEnabled = true;
            this.oda_combobox.Location = new System.Drawing.Point(127, 156);
            this.oda_combobox.Name = "oda_combobox";
            this.oda_combobox.Size = new System.Drawing.Size(200, 21);
            this.oda_combobox.TabIndex = 6;
            this.oda_combobox.SelectedIndexChanged += new System.EventHandler(this.oda_combobox_SelectedIndexChanged);
            // 
            // oda_label
            // 
            this.oda_label.AutoSize = true;
            this.oda_label.Location = new System.Drawing.Point(12, 164);
            this.oda_label.Name = "oda_label";
            this.oda_label.Size = new System.Drawing.Size(27, 13);
            this.oda_label.TabIndex = 19;
            this.oda_label.Text = "Oda";
            // 
            // durum_label
            // 
            this.durum_label.AutoSize = true;
            this.durum_label.Location = new System.Drawing.Point(199, 228);
            this.durum_label.Name = "durum_label";
            this.durum_label.Size = new System.Drawing.Size(0, 13);
            this.durum_label.TabIndex = 20;
            // 
            // M_Ekle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 258);
            this.Controls.Add(this.durum_label);
            this.Controls.Add(this.oda_label);
            this.Controls.Add(this.oda_combobox);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.giris_dateTimePicker);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.telno_text);
            this.Controls.Add(this.soyad_text);
            this.Controls.Add(this.tcno_text);
            this.Controls.Add(this.ad_text);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "M_Ekle_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Musteri";
            this.Load += new System.EventHandler(this.M_Ekle_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad_text;
        private System.Windows.Forms.TextBox tcno_text;
        private System.Windows.Forms.TextBox soyad_text;
        private System.Windows.Forms.TextBox telno_text;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label tcno;
        private System.Windows.Forms.Label telno;
        private System.Windows.Forms.Label giris;
        private System.Windows.Forms.DateTimePicker giris_dateTimePicker;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.ComboBox oda_combobox;
        private System.Windows.Forms.Label oda_label;
        private System.Windows.Forms.Label durum_label;

    }
}