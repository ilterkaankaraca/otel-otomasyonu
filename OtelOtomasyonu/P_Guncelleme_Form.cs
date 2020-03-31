using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtelOtomasyonu
{
    
    public partial class P_Guncelleme_Form : Form
    {
        VeriTabani vt = new VeriTabani();
        public P_Guncelleme_Form()
        {
            InitializeComponent();
        }

        
        public P_Guncelleme_Form(string id)
        {
            InitializeComponent();
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
            
            VeriTabani.komut = new OleDbCommand("Select * From girisbilgileri where id='"+ id +"'", Program.baglan);
            VeriTabani.okuyucu = VeriTabani.komut.ExecuteReader();
            if (VeriTabani.okuyucu.Read() == true)
            {
                id_textbox.Text = VeriTabani.okuyucu["id"].ToString();
                password_textbox.Text = VeriTabani.okuyucu["password"].ToString();
                password_t_textbox.Text = VeriTabani.okuyucu["password"].ToString();
                ad_textbox.Text = VeriTabani.okuyucu["ad"].ToString();
                soyad_textbox.Text = VeriTabani.okuyucu["soyad"].ToString();              
            }
        }
        private void geri_button_Click(object sender, EventArgs e)
        {
            Yonetici_Form y_frm = new Yonetici_Form();
            y_frm.Show();
            this.Hide();
        }

        private void kaydet_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ad_textbox.Text) || string.IsNullOrWhiteSpace(soyad_textbox.Text) || string.IsNullOrWhiteSpace(password_textbox.Text) || string.IsNullOrWhiteSpace(id_textbox.Text))
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Lutfen Tum Kutucukları Doldurun";
            }
            else if(password_textbox.Text == password_t_textbox.Text)
            {
                if (string.IsNullOrWhiteSpace(tip_combobox.Text))
                {
                    if (vt.Guncelle(id_textbox.Text, password_textbox.Text, ad_textbox.Text, soyad_textbox.Text, VeriTabani.okuyucu["tip"].ToString()) == true)
                    {
                        durum_label.ForeColor = System.Drawing.Color.Green;
                        durum_label.Text = "Islem Basarili";
                        id_textbox.Text = null;
                        ad_textbox.Text = null;
                        soyad_textbox.Text = null;
                        password_textbox.Text = null;
                        password_t_textbox.Text = null;
                        tip_combobox.Text = null;
                    }
                    else
                    {
                        durum_label.ForeColor = System.Drawing.Color.Red;
                        durum_label.Text = "Islem Basarisiz";
                    }
                }
                else
                {

                    if (vt.Guncelle(id_textbox.Text, password_textbox.Text, ad_textbox.Text, soyad_textbox.Text, tip_combobox.Text) == true)
                    {
                        durum_label.ForeColor = System.Drawing.Color.Green;
                        durum_label.Text = "Islem Basarili";
                    }
                    else
                    {
                        durum_label.ForeColor = System.Drawing.Color.Red;
                        durum_label.Text = "Islem Basarisiz";
                    }
                }
            }
            else
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Girdiginiz parolalar uyusmuyor";
            }

        }
            
        

        private void P_Guncelleme_Form_Load(object sender, EventArgs e)
        {
            tip_combobox.Items.Add("Yonetici");
            tip_combobox.Items.Add("Personel");
        }

        public string id { get; set; }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            
            password_textbox.PasswordChar = '•';   
        }

        private void password_t_textbox_TextChanged(object sender, EventArgs e)
        {
            password_t_textbox.PasswordChar = '•';
        }

        private void P_Guncelleme_Form_FormClosing(object sender, FormClosingEventArgs e)
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
