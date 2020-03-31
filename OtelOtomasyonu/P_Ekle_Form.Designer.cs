namespace OtelOtomasyonu
{
    partial class P_Ekle_Form
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
            this.ad_label = new System.Windows.Forms.Label();
            this.soyad_label = new System.Windows.Forms.Label();
            this.psswrd_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.ad_textbox = new System.Windows.Forms.TextBox();
            this.soyad_textbox = new System.Windows.Forms.TextBox();
            this.psswrd_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.psswrd_t_label = new System.Windows.Forms.Label();
            this.psswrd_t_textbox = new System.Windows.Forms.TextBox();
            this.tip_combobox = new System.Windows.Forms.ComboBox();
            this.tip_label = new System.Windows.Forms.Label();
            this.kaydet_button = new System.Windows.Forms.Button();
            this.geri_button = new System.Windows.Forms.Button();
            this.durum_label = new System.Windows.Forms.Label();
            this.ad_durum_label = new System.Windows.Forms.Label();
            this.soyad_durum_label = new System.Windows.Forms.Label();
            this.id_durum_label = new System.Windows.Forms.Label();
            this.password_durum_label = new System.Windows.Forms.Label();
            this.password_t_durum_label = new System.Windows.Forms.Label();
            this.tip_durum_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Location = new System.Drawing.Point(12, 29);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(20, 13);
            this.ad_label.TabIndex = 0;
            this.ad_label.Text = "Ad";
            // 
            // soyad_label
            // 
            this.soyad_label.AutoSize = true;
            this.soyad_label.Location = new System.Drawing.Point(12, 56);
            this.soyad_label.Name = "soyad_label";
            this.soyad_label.Size = new System.Drawing.Size(37, 13);
            this.soyad_label.TabIndex = 1;
            this.soyad_label.Text = "Soyad";
            // 
            // psswrd_label
            // 
            this.psswrd_label.AutoSize = true;
            this.psswrd_label.Location = new System.Drawing.Point(14, 108);
            this.psswrd_label.Name = "psswrd_label";
            this.psswrd_label.Size = new System.Drawing.Size(28, 13);
            this.psswrd_label.TabIndex = 2;
            this.psswrd_label.Text = "Sifre";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(12, 82);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(64, 13);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "Kullanici Adi";
            // 
            // ad_textbox
            // 
            this.ad_textbox.Location = new System.Drawing.Point(85, 26);
            this.ad_textbox.Name = "ad_textbox";
            this.ad_textbox.Size = new System.Drawing.Size(200, 20);
            this.ad_textbox.TabIndex = 0;
            this.ad_textbox.Tag = "";
            // 
            // soyad_textbox
            // 
            this.soyad_textbox.Location = new System.Drawing.Point(85, 53);
            this.soyad_textbox.Name = "soyad_textbox";
            this.soyad_textbox.Size = new System.Drawing.Size(200, 20);
            this.soyad_textbox.TabIndex = 1;
            // 
            // psswrd_textbox
            // 
            this.psswrd_textbox.Location = new System.Drawing.Point(85, 105);
            this.psswrd_textbox.Name = "psswrd_textbox";
            this.psswrd_textbox.Size = new System.Drawing.Size(200, 20);
            this.psswrd_textbox.TabIndex = 3;
            this.psswrd_textbox.TextChanged += new System.EventHandler(this.psswrd_textbox_TextChanged);
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(85, 79);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(200, 20);
            this.id_textbox.TabIndex = 2;
            // 
            // psswrd_t_label
            // 
            this.psswrd_t_label.AutoSize = true;
            this.psswrd_t_label.Location = new System.Drawing.Point(15, 134);
            this.psswrd_t_label.Name = "psswrd_t_label";
            this.psswrd_t_label.Size = new System.Drawing.Size(65, 13);
            this.psswrd_t_label.TabIndex = 8;
            this.psswrd_t_label.Text = "Sifre(Tekrar)";
            // 
            // psswrd_t_textbox
            // 
            this.psswrd_t_textbox.Location = new System.Drawing.Point(86, 131);
            this.psswrd_t_textbox.Name = "psswrd_t_textbox";
            this.psswrd_t_textbox.Size = new System.Drawing.Size(200, 20);
            this.psswrd_t_textbox.TabIndex = 4;
            this.psswrd_t_textbox.TextChanged += new System.EventHandler(this.psswrd_t_textbox_TextChanged);
            // 
            // tip_combobox
            // 
            this.tip_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tip_combobox.FormattingEnabled = true;
            this.tip_combobox.Location = new System.Drawing.Point(85, 159);
            this.tip_combobox.Name = "tip_combobox";
            this.tip_combobox.Size = new System.Drawing.Size(200, 21);
            this.tip_combobox.TabIndex = 5;
            // 
            // tip_label
            // 
            this.tip_label.AutoSize = true;
            this.tip_label.Location = new System.Drawing.Point(14, 162);
            this.tip_label.Name = "tip_label";
            this.tip_label.Size = new System.Drawing.Size(66, 13);
            this.tip_label.TabIndex = 11;
            this.tip_label.Text = "Kullanici Tipi";
            // 
            // kaydet_button
            // 
            this.kaydet_button.Location = new System.Drawing.Point(12, 223);
            this.kaydet_button.Name = "kaydet_button";
            this.kaydet_button.Size = new System.Drawing.Size(75, 23);
            this.kaydet_button.TabIndex = 12;
            this.kaydet_button.Text = "Kaydet";
            this.kaydet_button.UseVisualStyleBackColor = true;
            this.kaydet_button.Click += new System.EventHandler(this.kaydet_button_Click);
            // 
            // geri_button
            // 
            this.geri_button.Location = new System.Drawing.Point(93, 223);
            this.geri_button.Name = "geri_button";
            this.geri_button.Size = new System.Drawing.Size(75, 23);
            this.geri_button.TabIndex = 13;
            this.geri_button.Text = "Geri";
            this.geri_button.UseVisualStyleBackColor = true;
            this.geri_button.Click += new System.EventHandler(this.geri_button_Click);
            // 
            // durum_label
            // 
            this.durum_label.AutoSize = true;
            this.durum_label.Location = new System.Drawing.Point(174, 228);
            this.durum_label.Name = "durum_label";
            this.durum_label.Size = new System.Drawing.Size(0, 13);
            this.durum_label.TabIndex = 14;
            // 
            // ad_durum_label
            // 
            this.ad_durum_label.AutoSize = true;
            this.ad_durum_label.Location = new System.Drawing.Point(191, 29);
            this.ad_durum_label.Name = "ad_durum_label";
            this.ad_durum_label.Size = new System.Drawing.Size(0, 13);
            this.ad_durum_label.TabIndex = 15;
            // 
            // soyad_durum_label
            // 
            this.soyad_durum_label.AutoSize = true;
            this.soyad_durum_label.Location = new System.Drawing.Point(191, 56);
            this.soyad_durum_label.Name = "soyad_durum_label";
            this.soyad_durum_label.Size = new System.Drawing.Size(0, 13);
            this.soyad_durum_label.TabIndex = 16;
            // 
            // id_durum_label
            // 
            this.id_durum_label.AutoSize = true;
            this.id_durum_label.Location = new System.Drawing.Point(191, 82);
            this.id_durum_label.Name = "id_durum_label";
            this.id_durum_label.Size = new System.Drawing.Size(0, 13);
            this.id_durum_label.TabIndex = 17;
            // 
            // password_durum_label
            // 
            this.password_durum_label.AutoSize = true;
            this.password_durum_label.Location = new System.Drawing.Point(191, 108);
            this.password_durum_label.Name = "password_durum_label";
            this.password_durum_label.Size = new System.Drawing.Size(0, 13);
            this.password_durum_label.TabIndex = 18;
            // 
            // password_t_durum_label
            // 
            this.password_t_durum_label.AutoSize = true;
            this.password_t_durum_label.Location = new System.Drawing.Point(192, 134);
            this.password_t_durum_label.Name = "password_t_durum_label";
            this.password_t_durum_label.Size = new System.Drawing.Size(0, 13);
            this.password_t_durum_label.TabIndex = 19;
            // 
            // tip_durum_label
            // 
            this.tip_durum_label.AutoSize = true;
            this.tip_durum_label.Location = new System.Drawing.Point(212, 162);
            this.tip_durum_label.Name = "tip_durum_label";
            this.tip_durum_label.Size = new System.Drawing.Size(0, 13);
            this.tip_durum_label.TabIndex = 20;
            // 
            // P_Ekle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 258);
            this.Controls.Add(this.tip_durum_label);
            this.Controls.Add(this.password_t_durum_label);
            this.Controls.Add(this.password_durum_label);
            this.Controls.Add(this.id_durum_label);
            this.Controls.Add(this.soyad_durum_label);
            this.Controls.Add(this.ad_durum_label);
            this.Controls.Add(this.durum_label);
            this.Controls.Add(this.geri_button);
            this.Controls.Add(this.kaydet_button);
            this.Controls.Add(this.tip_label);
            this.Controls.Add(this.tip_combobox);
            this.Controls.Add(this.psswrd_t_textbox);
            this.Controls.Add(this.psswrd_t_label);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.psswrd_textbox);
            this.Controls.Add(this.soyad_textbox);
            this.Controls.Add(this.ad_textbox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.psswrd_label);
            this.Controls.Add(this.soyad_label);
            this.Controls.Add(this.ad_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(374, 301);
            this.MinimumSize = new System.Drawing.Size(374, 301);
            this.Name = "P_Ekle_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Personel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.P_Ekle_Form_FormClosing);
            this.Load += new System.EventHandler(this.P_Ekle_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.Label soyad_label;
        private System.Windows.Forms.Label psswrd_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox ad_textbox;
        private System.Windows.Forms.TextBox soyad_textbox;
        private System.Windows.Forms.TextBox psswrd_textbox;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label psswrd_t_label;
        private System.Windows.Forms.TextBox psswrd_t_textbox;
        private System.Windows.Forms.ComboBox tip_combobox;
        private System.Windows.Forms.Label tip_label;
        private System.Windows.Forms.Button kaydet_button;
        private System.Windows.Forms.Button geri_button;
        private System.Windows.Forms.Label durum_label;
        private System.Windows.Forms.Label ad_durum_label;
        private System.Windows.Forms.Label soyad_durum_label;
        private System.Windows.Forms.Label id_durum_label;
        private System.Windows.Forms.Label password_durum_label;
        private System.Windows.Forms.Label password_t_durum_label;
        private System.Windows.Forms.Label tip_durum_label;
    }
}