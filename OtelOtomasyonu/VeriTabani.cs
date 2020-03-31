using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    class VeriTabani
    {
        public static DataTable tablo;
        public static OleDbCommand komut;
        public static OleDbCommand komut2;
        public static OleDbDataReader okuyucu;


        public void Listele(string tablo_ad)
        {
            tablo = new DataTable();
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From " + tablo_ad, Program.baglan);
            adapter.Fill(tablo);
   }
        public void Listele(string tablo_ad, string a, string b)
        {
            tablo = new DataTable();
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from " + tablo_ad + " where " + b + " Like '" + a + "%'", Program.baglan);
            adapter.Fill(tablo);
        }
        public bool Ekle(string id, string password, string ad, string soyad, string tip)
        {
            VeriTabani.komut = new OleDbCommand("Insert into girisbilgileri (id, [password], ad, soyad, tip) values (@id, @password, @ad, @soyad, @tip)", Program.baglan);
            VeriTabani.komut2 = new OleDbCommand("Select * From girisbilgileri where id= '" + id + "'", Program.baglan);
            if (ConnectionState.Closed == Program.baglan.State)
                Program.baglan.Open();
            VeriTabani.okuyucu = komut2.ExecuteReader();
            if (okuyucu.Read())
            {
                return false;
            }
            else
            {
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@password", password);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@tip", tip.ToLower());
                komut.ExecuteNonQuery();
                if (ConnectionState.Open == Program.baglan.State)
                    Program.baglan.Close();
                return true;
            }
        }
        public bool Ekle(string id, string ad, string soyad, string tel, string giris, string oda)
        {
            VeriTabani.komut = new OleDbCommand("Insert into musteribilgileri (id, ad, soyad, telno, giris, odano) values (@id, @ad, @soyad, @tel, @giris, @odano)", Program.baglan);
            VeriTabani.komut2 = new OleDbCommand("Select * From musteribilgileri where id= '" + id + "'", Program.baglan);
            if (ConnectionState.Closed == Program.baglan.State)
                Program.baglan.Open();
            VeriTabani.okuyucu = komut2.ExecuteReader();

            if (okuyucu.Read() == true)
            {
                return false;
            }
            else
            {
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@telno", tel);
                komut.Parameters.AddWithValue("@giris", DateTime.Parse(giris));
                komut.Parameters.AddWithValue("@odano", oda);
                komut.ExecuteNonQuery();
                if (ConnectionState.Open == Program.baglan.State)
                    Program.baglan.Close();
                return true;
            }
        }
        public void Ekle(string id)
        {
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
            VeriTabani.komut = new OleDbCommand("Insert into log (id, giris) values (@id, @giris)", Program.baglan);
            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@giris", DateTime.Now.ToString());

            komut.ExecuteNonQuery();
            if (ConnectionState.Open == Program.baglan.State)
            {
                Program.baglan.Close();
            }
        }
        public bool Sil(string tablo_ad, string id)
        {
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();

                if (tablo_ad == "girisbilgileri")
                {
                    VeriTabani.komut = new OleDbCommand("Select * From girisbilgileri where id= '" + id + "'", Program.baglan);
                    VeriTabani.okuyucu = komut.ExecuteReader();
                    Console.WriteLine(id);
                    Console.WriteLine(tablo_ad);
                    VeriTabani.okuyucu.Read();
                    if (VeriTabani.okuyucu["tip"].ToString() == "yonetici")
                    {
                        VeriTabani.komut2 = new OleDbCommand("Select Count(*) from girisbilgileri where tip = 'yonetici'", Program.baglan);
                        int sayac = (int)VeriTabani.komut2.ExecuteScalar();
                        if (sayac == 1)
                        {
                           
                            return false;
                        }
                        else
                        {

                            VeriTabani.komut = new OleDbCommand("Delete from " + tablo_ad + " where id='" + id + "'", Program.baglan);
                            komut.ExecuteNonQuery();

                            return true;
                        }
                    }
                    else
                    {

                        VeriTabani.komut = new OleDbCommand("Delete from " + tablo_ad + " where id='" + id + "'", Program.baglan);
                        komut.ExecuteNonQuery();

                        return true;
                    }
                }
                else
                {

                    VeriTabani.komut = new OleDbCommand("Delete from " + tablo_ad + " where id='" + id + "'", Program.baglan);
                    komut.ExecuteNonQuery();
                    return true;
                }
            }
            return false;
        }
        public bool Guncelle(string id, string password, string ad, string soyad, string tip)
        {
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
            VeriTabani.komut = new OleDbCommand("UPDATE girisbilgileri SET [password] = @password, ad = @ad, soyad = @soyad, tip = @tip WHERE id = @id", Program.baglan);
            komut.Parameters.AddWithValue("@password", password);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@tip", tip.ToLower());
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            if (ConnectionState.Open == Program.baglan.State)
            {
                Program.baglan.Close();
            }
            //Listele("girisbilgileri");
            return true;
        }
        public bool Guncelle(string id, string ad, string soyad, string tel, DateTime giris, string oda)
        {
            if (ConnectionState.Closed == Program.baglan.State)
                Program.baglan.Open();
            VeriTabani.komut2 = new OleDbCommand("Select * From musteribilgileri where id= '" + id + "'", Program.baglan);
            VeriTabani.okuyucu = komut.ExecuteReader();
            VeriTabani.okuyucu.Read();
            
            if (oda != null)
            {
                VeriTabani.komut = new OleDbCommand("UPDATE musteribilgileri SET ad = @ad, soyad = @soyad, telno = @telno, giris = @giris, odano = @odano WHERE id = @id", Program.baglan);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@telno", tel);
                komut.Parameters.AddWithValue("@giris", giris);
                komut.Parameters.AddWithValue("@odano", oda);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
            //else
            //{
            //    VeriTabani.komut = new OleDbCommand("UPDATE musteribilgileri SET ad = @ad, soyad = @soyad, telno = @telno, giris = @giris,  odano = @odano,  WHERE id = @id", Program.baglan);
            //    komut.Parameters.AddWithValue("@ad", ad);
            //    komut.Parameters.AddWithValue("@soyad", soyad);
            //    komut.Parameters.AddWithValue("@telno", tel);
            //    komut.Parameters.AddWithValue("@odano", oda);
            //    komut.Parameters.AddWithValue("@giris", giris);
            //    komut.Parameters.AddWithValue("@id", id);
            //    komut.ExecuteNonQuery();
            //}
           if (ConnectionState.Open == Program.baglan.State)
           {
               Program.baglan.Close();
           }
            return true;
        }
        public void Guncelle(string id, string durum)
        {
            if (ConnectionState.Closed == Program.baglan.State)
            {
                Program.baglan.Open();
            }
            VeriTabani.komut2 = new OleDbCommand("UPDATE odabilgileri SET durum = @durum where id= @id ", Program.baglan);
            komut2.Parameters.AddWithValue("@durum", durum);
            komut2.Parameters.AddWithValue("@id", id);
            komut2.ExecuteNonQuery();
            if (ConnectionState.Open == Program.baglan.State)
            {
                Program.baglan.Close();
            }
        }
        public object password { get; set; }
        public object ad { get; set; }
        public object soyad { get; set; }
        public object tipi { get; set; }
        public object tip { get; set; }
    }
}
