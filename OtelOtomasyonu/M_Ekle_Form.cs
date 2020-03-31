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
    public partial class M_Ekle_Form : Form
    {
        VeriTabani vt = new VeriTabani();
        public Form frm;
        public M_Ekle_Form()
        {
            InitializeComponent();
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
                //Listeye sadece boş olanların eklendiği kısım
                VeriTabani.komut = new OleDbCommand("Select * From odabilgileri where durum='bos'", Program.baglan);
                VeriTabani.okuyucu = VeriTabani.komut.ExecuteReader();
                while (VeriTabani.okuyucu.Read() == true)
                {
                    oda_combobox.Items.Add(VeriTabani.okuyucu["id"]);
                }
                giris_dateTimePicker.MinDate = DateTime.Today;
                tcno_text.MaxLength = 11;
                telno_text.MaxLength = 12;
            
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ad_text.Text.ToString()) || string.IsNullOrEmpty(soyad_text.Text.ToString()) || string.IsNullOrEmpty(tcno_text.Text.ToString()) || string.IsNullOrEmpty(telno_text.Text.ToString()) ||string.IsNullOrEmpty(oda_combobox.Text.ToString()))
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Lutfen Tum Kutucuklari Doldurunuz";
            }
            else if (vt.Ekle(tcno_text.Text, ad_text.Text, soyad_text.Text, telno_text.Text, giris_dateTimePicker.Text, oda_combobox.Text) == true)
            {
                durum_label.ForeColor = System.Drawing.Color.Green;
                durum_label.Text = "Kayit Basarili";
                vt.Guncelle(oda_combobox.Text, "dolu");
                ad_text.Text = null;
                soyad_text.Text = null;
                tcno_text.Text = null;
                telno_text.Text = null;
                oda_combobox.Text = null;
            }
            else
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Girilen Kimlik Numarasi Kayitli";
            }
        }

        private void iptal_Click(object sender, EventArgs e)
        {

            frm.Show();
            this.Hide();


        }

        private void M_Ekle_Form_Load(object sender, EventArgs e)
        {
            durum_label.Text = ""; 
            


        }



        private void ad_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);

        }

        private void soyad_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);
        }
        private void tc_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);

        }
        private void tel_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);

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

        private void oda_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
