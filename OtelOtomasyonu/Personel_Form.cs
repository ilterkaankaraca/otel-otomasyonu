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
    
    public partial class Personel_Form : Form
    {
        VeriTabani vt = new VeriTabani();
        DataGridViewCellEventArgs k;
        public Form frm;
        int s = 0;

        public Personel_Form()
        {
            InitializeComponent();
            
        }

        public Personel_Form(string yonetici)
        {
            InitializeComponent();
            yoneticiEkranıToolStripMenuItem.Visible=true;

        }

        private void Personel_Form_Load(object sender, EventArgs e)
        {
           
            vt.Listele("musteribilgileri");
            s = 0;
            listedatagrid.DataSource = VeriTabani.tablo;
            listedatagrid.Columns[0].HeaderText = "Adı";
            listedatagrid.Columns[1].HeaderText = "Soyadı";
            listedatagrid.Columns[2].HeaderText = "Kimlik Numarası";
            listedatagrid.Columns[3].HeaderText = "Telefonu Numarası";
            listedatagrid.Columns[4].HeaderText = "Giriş Yapılan Tarih";
            listedatagrid.Columns[5].HeaderText = "Oda Numarası";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
                Program.baglan.Close();
            column_combobox.Items.Add("Adı");
            column_combobox.Items.Add("Soyadı");
            column_combobox.Items.Add("Kimlik Numarası");
            column_combobox.Items.Add("Telefonu Numarası");
            column_combobox.Items.Add("Oda Numarası");
        }

        private void yeni_button_Click(object sender, EventArgs e)
        {
            M_Ekle_Form m_ekle = new M_Ekle_Form();
            m_ekle.frm = this;
            m_ekle.Show();
            this.Hide();
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
 
                if (vt.Sil("musteribilgileri", listedatagrid.Rows[k.RowIndex].Cells[2].Value.ToString()) == true)
                {
                    vt.Guncelle(listedatagrid.Rows[k.RowIndex].Cells[5].Value.ToString(), "bos");
                    listedatagrid.Rows.Remove(listedatagrid.Rows[k.RowIndex]);
                    durum_label.ForeColor = System.Drawing.Color.Green;
                    durum_label.Text = "Kayit Silindi";
                    guncelle_button.Hide();
                    sil_button.Hide();
                    
                }
                else
                {
                    durum_label.ForeColor = System.Drawing.Color.Red;
                    durum_label.Text = "Islem Basarisiz Oldu";
                }
            
        }

        private void listedatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (s == 0)
                {
                    k = e;
                    sil_button.Visible = true;
                    guncelle_button.Visible = true;
                }
            }
        }

        private void guncelle_button_Click(object sender, EventArgs e)
        {

                M_Guncelle_Form mgncfrm = new M_Guncelle_Form(listedatagrid.Rows[k.RowIndex].Cells[2].Value.ToString());
                mgncfrm.frm = this;
                mgncfrm.Show();
                this.Hide();
                guncelle_button.Hide();
                sil_button.Hide();
                vt.Listele("musteribilgileri");
                listedatagrid.DataSource = VeriTabani.tablo;
                listedatagrid.Columns[0].HeaderText = "Adı";
                listedatagrid.Columns[1].HeaderText = "Soyadı";
                listedatagrid.Columns[2].HeaderText = "Kimlik Numarası";
                listedatagrid.Columns[3].HeaderText = "Telefonu Numarası";
                listedatagrid.Columns[4].HeaderText = "Giriş Yapılan Tarih";
                listedatagrid.Columns[5].HeaderText = "Oda Numarası";
                VeriTabani.tablo.AcceptChanges();
            
        }

        private void odaListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guncelle_button.Hide();
            sil_button.Hide();
            vt.Listele("odabilgileri");
            s = 1;
            listedatagrid.DataSource = VeriTabani.tablo;
            listedatagrid.Columns[0].HeaderText = "Numara";
            listedatagrid.Columns[1].HeaderText = "Durumu";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
                Program.baglan.Close();
        }

        private void odaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle_button.Hide();
            sil_button.Hide();
            vt.Listele("musteribilgileri");
            s = 0;
            listedatagrid.DataSource = VeriTabani.tablo;           
            listedatagrid.Columns[0].HeaderText = "Adı";
            listedatagrid.Columns[1].HeaderText = "Soyadı";
            listedatagrid.Columns[2].HeaderText = "Kimlik Numarası";
            listedatagrid.Columns[3].HeaderText = "Telefonu Numarası";
            listedatagrid.Columns[4].HeaderText = "Giriş Yapılan Tarih";
            listedatagrid.Columns[5].HeaderText = "Oda Numarası";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
                Program.baglan.Close();
        }

        private void Personel_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void yoneticiEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yonetici_Form yform = new Yonetici_Form();
            yform.Show();
            this.Hide();
        }

        private void ara_button_Click(object sender, EventArgs e)
        {
            if (column_combobox.Text == "Adı")
            {
                vt.Listele("musteribilgileri", arama_textbox.Text, "ad");    
            }
            else if (column_combobox.Text == "Soyadı")
            {
                vt.Listele("musteribilgileri", arama_textbox.Text, "soyad");   
            }
            else if (column_combobox.Text == "Kimlik Numarası")
            {
                vt.Listele("musteribilgileri", arama_textbox.Text, "id");    
            }
            else if (column_combobox.Text == "Telefon Numarası")
            {
                vt.Listele("musteribilgileri", arama_textbox.Text, "telno");
            }
            else if (column_combobox.Text == "Oda Numarası")
            {
                vt.Listele("musteribilgileri", arama_textbox.Text, "oda"); 
            }
            listedatagrid.DataSource = VeriTabani.tablo;
            listedatagrid.Columns[0].HeaderText = "Adı";
            listedatagrid.Columns[1].HeaderText = "Soyadı";
            listedatagrid.Columns[2].HeaderText = "Kimlik Numarası";
            listedatagrid.Columns[3].HeaderText = "Telefonu Numarası";
            listedatagrid.Columns[4].HeaderText = "Giriş Yapılan Tarih";
            listedatagrid.Columns[5].HeaderText = "Oda Numarası";
            VeriTabani.tablo.AcceptChanges();
            if (ConnectionState.Open == Program.baglan.State)
                Program.baglan.Close();
            

        }
    }
}
