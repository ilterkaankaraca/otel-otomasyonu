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
    public partial class M_Guncelle_Form : Form
    {
        VeriTabani vt = new VeriTabani();
        string oda2;
        public Form frm;

        public M_Guncelle_Form()
        {

            InitializeComponent();

        }
        public M_Guncelle_Form(string id)
        {
            InitializeComponent();
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
            VeriTabani.komut = new OleDbCommand("Select * From musteribilgileri where id='" + id + "'", Program.baglan);
            VeriTabani.okuyucu = VeriTabani.komut.ExecuteReader();

            if (VeriTabani.okuyucu.Read() == true)
            {

                tcno_text.Text = VeriTabani.okuyucu["id"].ToString();
                ad_text.Text = VeriTabani.okuyucu["ad"].ToString();
                soyad_text.Text = VeriTabani.okuyucu["soyad"].ToString();
                telno_text.Text = VeriTabani.okuyucu["telno"].ToString();
                giris_dateTimePicker.Value = Convert.ToDateTime(VeriTabani.okuyucu["giris"]);
                oda2 = VeriTabani.okuyucu["odano"].ToString();

                if (ConnectionState.Open == Program.baglan.State)
                {
                    Program.baglan.Close();
                }
            }

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ad_text.Text.ToString()) || string.IsNullOrEmpty(soyad_text.Text.ToString()) || string.IsNullOrEmpty(tcno_text.Text.ToString()) || string.IsNullOrEmpty(telno_text.Text.ToString()))
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Lutfen Tum Kutucuklari Doldurunuz";
            }
            else if (string.IsNullOrWhiteSpace(oda_combobox.Text))
            {
                vt.Ekle(tcno_text.Text, ad_text.Text, soyad_text.Text, giris_dateTimePicker.Text, oda2); 
                durum_label.ForeColor = System.Drawing.Color.Green;
                durum_label.Text = "Islem Basarili";
            }
            else if (vt.Guncelle(tcno_text.Text, ad_text.Text, soyad_text.Text, telno_text.Text, giris_dateTimePicker.Value, oda_combobox.Text.ToString()) == true)
            {
                Console.WriteLine("2");
                vt.Guncelle(oda2, "bos");
                vt.Guncelle(oda_combobox.Text, "dolu");
                durum_label.ForeColor = System.Drawing.Color.Green;
                durum_label.Text = "Islem Basarili";
            }
            else
            {
                durum_label.ForeColor = System.Drawing.Color.Red;
                durum_label.Text = "Girilen Kimlik Numarasi Kayitli";
            }

        }

        public string id { get; set; }

        private void M_Guncelle_Form_Load(object sender, EventArgs e)
        {
            if (ConnectionState.Closed == Program.baglan.State)
                Program.baglan.Open();
            VeriTabani.komut = new OleDbCommand("Select * From odabilgileri where durum='bos'", Program.baglan);
            VeriTabani.okuyucu = VeriTabani.komut.ExecuteReader();
            while (VeriTabani.okuyucu.Read() == true)
            {
                oda_combobox.Items.Add(VeriTabani.okuyucu["id"]);
            }
            if (ConnectionState.Open == Program.baglan.State)
            {
                Program.baglan.Close();
            }
            giris_dateTimePicker.MinDate = DateTime.Today;

        }

        private void iptal_Click(object sender, EventArgs e)
        {

            frm.Show();
            this.Hide();
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