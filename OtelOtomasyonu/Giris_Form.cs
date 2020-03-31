using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class Giris_Form : Form
    {
        VeriTabani vt = new VeriTabani();

        public Giris_Form()
        {
            InitializeComponent();
        }

        private void Giris_Bbutonu_Click(object sender, EventArgs e)
        {
            if (ConnectionState.Closed == Program.baglan.State)
                Program.baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select * From girisbilgileri where id='" + id.Text.ToString() + "'", Program.baglan);
            OleDbDataReader reader = komut.ExecuteReader();

            if (reader.Read() == true)
            {
                if (pssword.Text.ToString() == reader["password"].ToString())
                {
                    if (reader["tip"].ToString() == "yonetici" )
                    {
                        Yonetici_Form yonetici_frm = new Yonetici_Form();
                        yonetici_frm.Show();
                        this.Hide();
                        vt.Ekle(id.Text);
                    }
                    else if (reader["tip"].ToString() == "personel")
                    {
                        Personel_Form personel_frm = new Personel_Form();
                        personel_frm.Show();
                        this.Hide();
                        vt.Ekle(id.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanici Adi veya Sifre Yanlis");
                }
            }
            else
                MessageBox.Show("Kullanici Adi veya Sifre Yanlis");
        }
        private void Giris_Butonu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void pssword_TextChanged(object sender, EventArgs e)
        {
            pssword.PasswordChar = '•';
        }
        private void id_TextChanged(object sender, EventArgs e)
        {

        }
        private void Giris_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}