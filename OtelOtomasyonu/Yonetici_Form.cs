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
    public partial class Yonetici_Form : Form
    {
        VeriTabani vt = new VeriTabani();
        DataGridViewCellEventArgs k;
        public Form frm;
        public int cell;
        
        
        public Yonetici_Form()
        {
            InitializeComponent();
            
        }
        private void Yonetici_Form_Load(object sender, EventArgs e)
        {
            
            vt.Listele("girisbilgileri");
            s = 0;
            dataGridView1.DataSource = VeriTabani.tablo;
            dataGridView1.Columns[0].HeaderText = "Kullanici Adi";
            dataGridView1.Columns[1].HeaderText = "Sifre";
            dataGridView1.Columns[2].HeaderText = "Adı";
            dataGridView1.Columns[3].HeaderText = "Soyadı";
            dataGridView1.Columns[4].HeaderText = "Kullanici Tipi";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
            {
                Program.baglan.Close();
            }
            column_combobox.Items.Add("Kullanici Adi");
            column_combobox.Items.Add("Adı");
            column_combobox.Items.Add("Soyadı");
            column_combobox.Items.Add("Kullanici Tipi");

        }
        private void Yeni_Personel_Button_Click(object sender, EventArgs e)
        {
            P_Ekle_Form p_ekle_frm = new P_Ekle_Form();
            p_ekle_frm.Show();
            this.Hide();
        }
        private void sil_button_Click(object sender, EventArgs e)
        {

                if (vt.Sil("girisbilgileri", dataGridView1.Rows[k.RowIndex].Cells[0].Value.ToString()) == true)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[k.RowIndex]);
                    durum_label.ForeColor = System.Drawing.Color.Green;
                    durum_label.Text = "Kayit Silindi";
                    guncelle_buton.Hide();
                    sil_button.Hide();
                }
                else
                {
                    durum_label.ForeColor = System.Drawing.Color.Red;
                    durum_label.Text = "En az bir Yönetici bulunmak zorundadır";
                }
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (s == 0)
            {
                if (e.RowIndex >= 0)
                {
                    k = e;
                    sil_button.Show();
                    guncelle_buton.Show();

                }
            }
            
        }
        private void guncelle_buton_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                if (k.RowIndex >= 0)
                {
                    string id = dataGridView1.Rows[k.RowIndex].Cells[0].Value.ToString();
                    P_Guncelleme_Form p_g = new P_Guncelleme_Form(id);
                    p_g.Show();
                    this.Hide();
                    guncelle_buton.Hide();
                    sil_button.Hide();
                }
                else
                {
                    durum_label.Text = "Lütfen bir kayıt seçiniz";
                }
            }
        }
        private void Yonetici_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vt.Listele("log");
            s = 1;
            guncelle_buton.Hide();
            sil_button.Hide();
            dataGridView1.DataSource = VeriTabani.tablo;
            dataGridView1.Columns[1].HeaderText = "Kullanici Adi";
            dataGridView1.Columns[2].HeaderText = "Giriş";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
                Program.baglan.Close();
        }
        private void personelEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Form pform = new Personel_Form("a");
            
            pform.Show();
            this.Hide();
        }
        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vt.Listele("girisbilgileri");
            s = 0;
            dataGridView1.DataSource = VeriTabani.tablo;
            dataGridView1.Columns[0].HeaderText = "Kullanici Adi";
            dataGridView1.Columns[1].HeaderText = "Sifre";
            dataGridView1.Columns[2].HeaderText = "Adı";
            dataGridView1.Columns[3].HeaderText = "Soyadı";
            dataGridView1.Columns[4].HeaderText = "Kullanici Tipi";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
            {
                Program.baglan.Close();
            }
        }
        private void ara_textbox_Click(object sender, EventArgs e)
        {
            if (column_combobox.Text == "Kullanici Adi")
            {
                vt.Listele("girisbilgileri", arama_textbox.Text, "id");
            }
            else if (column_combobox.Text == "Sifre")
            {
                vt.Listele("girisbilgileri", arama_textbox.Text, "password");
            }
            else if (column_combobox.Text == "Adı")
            {
                vt.Listele("girisbilgileri", arama_textbox.Text, "ad");
            }
            else if (column_combobox.Text == "Soyadı")
            {
                vt.Listele("girisbilgileri", arama_textbox.Text, "soyad");
            }
            else if (column_combobox.Text == "Kullanici Tipi")
            {
                vt.Listele("girisbilgileri", arama_textbox.Text, "tip");
            }
            dataGridView1.DataSource = VeriTabani.tablo;
            dataGridView1.Columns[0].HeaderText = "Kullanici Adi";
            dataGridView1.Columns[1].HeaderText = "Sifre";
            dataGridView1.Columns[2].HeaderText = "Adı";
            dataGridView1.Columns[3].HeaderText = "Soyadı";
            dataGridView1.Columns[4].HeaderText = "Kullanici Tipi";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
                Program.baglan.Close();
        }
    }
}
