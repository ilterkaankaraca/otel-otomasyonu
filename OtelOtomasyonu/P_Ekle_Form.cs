using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtelOtomasyonu
{


    public partial class P_Ekle_Form : Form
    {
        VeriTabani vt = new VeriTabani();
        Yonetici_Form y_frm = new Yonetici_Form();
        public Form frm;
        public P_Ekle_Form()
        {
            InitializeComponent();
        }



        private void P_Ekle_Form_Load(object sender, EventArgs e)
        {

            tip_combobox.Items.Add("Yonetici");
            tip_combobox.Items.Add("Personel");


        }

        private void kaydet_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_textbox.Text) || string.IsNullOrWhiteSpace(psswrd_textbox.Text) || string.IsNullOrWhiteSpace(ad_textbox.Text) || string.IsNullOrWhiteSpace(soyad_textbox.Text) || string.IsNullOrWhiteSpace(tip_combobox.Text))
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Lutfen Tum Kutucukları Doldurun";
            }
            else if (psswrd_textbox.Text.ToString() != psswrd_t_textbox.Text.ToString())
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Girdiginiz parolalar uyusmuyor";
            }
            else if (vt.Ekle(id_textbox.Text, psswrd_textbox.Text, ad_textbox.Text, soyad_textbox.Text, tip_combobox.Text) == true)
            {

                durum_label.ForeColor = System.Drawing.Color.Green;
                durum_label.Text = "Islem Basarili";
                ad_textbox.Text = null;
                soyad_textbox.Text = null;
                psswrd_textbox.Text = null;
                psswrd_t_textbox.Text = null;
                tip_combobox.Text = null;
            }
            else
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Islem Basarisiz";
            }

        }
        private void psswrd_textbox_TextChanged(object sender, EventArgs e)
        {
            psswrd_textbox.PasswordChar = '•';
        }
        private void psswrd_t_textbox_TextChanged(object sender, EventArgs e)
        {
            psswrd_t_textbox.PasswordChar = '•';
        }

        private void geri_button_Click(object sender, EventArgs e)
        {
            y_frm.Show();
            this.Hide();
        }

        private void P_Ekle_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }


        }
    }
}
