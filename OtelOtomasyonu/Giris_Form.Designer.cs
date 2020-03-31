namespace OtelOtomasyonu
{
    partial class Giris_Form
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
            this.id = new System.Windows.Forms.TextBox();
            this.pssword = new System.Windows.Forms.TextBox();
            this.Giris_Butonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musteriDataSet1 = new OtelOtomasyonu.musteriDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(96, 72);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            this.id.Tag = "";
            // 
            // pssword
            // 
            this.pssword.Location = new System.Drawing.Point(96, 95);
            this.pssword.Name = "pssword";
            this.pssword.Size = new System.Drawing.Size(100, 20);
            this.pssword.TabIndex = 1;
            this.pssword.TextChanged += new System.EventHandler(this.pssword_TextChanged);
            // 
            // Giris_Butonu
            // 
            this.Giris_Butonu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Giris_Butonu.Location = new System.Drawing.Point(106, 121);
            this.Giris_Butonu.Name = "Giris_Butonu";
            this.Giris_Butonu.Size = new System.Drawing.Size(75, 23);
            this.Giris_Butonu.TabIndex = 2;
            this.Giris_Butonu.Text = "Giris";
            this.Giris_Butonu.UseVisualStyleBackColor = false;
            this.Giris_Butonu.Click += new System.EventHandler(this.Giris_Bbutonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanici Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifre";
            // 
            // musteriDataSet1
            // 
            this.musteriDataSet1.DataSetName = "musteriDataSet";
            this.musteriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Giris_Form
            // 
            this.AcceptButton = this.Giris_Butonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Giris_Butonu);
            this.Controls.Add(this.pssword);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Giris_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pssword;
        private System.Windows.Forms.Button Giris_Butonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private musteriDataSet musteriDataSet1;
    }
}

