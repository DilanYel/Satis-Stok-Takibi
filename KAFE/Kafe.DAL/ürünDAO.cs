using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DAL
{
    public class ürünDAO
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430037;User ID= 26_132430037; Password=İnif123.;");
        public DataTable Listele()
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM ürün", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public void kaydet(string gürünadı, string gkategori, int gfiyat, int gstok, int gminstok, decimal gmaliyet)
        {
            baglanti.Open();
            string sql = "INSERT INTO ürün (ürünadı, kategori, fiyat, stok, minstok,maliyet) VALUES ('" + gürünadı + "','" + gkategori + "'," + gfiyat + "," + gstok + "," + gminstok + "," + gmaliyet + ")";
            (new MySqlCommand(sql, baglanti)).ExecuteNonQuery();

            baglanti.Close();
        }
        public void sil(int ürünId)
        {
            baglanti.Open();
            string sql = "DELETE FROM ürün WHERE ürünId= @id LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@id", ürünId);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public void güncelle(int gürünId, string gürünadı, string gkategori, decimal gfiyat, int gstok, int gminstok,decimal gmaliyet)
        {
            baglanti.Open();
            string sql = @"UPDATE ürün 
                   SET ürünadı = @urunAd,
                       kategori = @kategori,
                       fiyat = @fiyat,
                       stok = @stok,
                       minStok = @minStok,
                       maliyet=@maliyet
                   WHERE ürünId = @id
                   LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@urunAd", gürünadı);
            cmd.Parameters.AddWithValue("@kategori", gkategori);
            cmd.Parameters.AddWithValue("@fiyat", gfiyat);
            cmd.Parameters.AddWithValue("@stok", gstok);
            cmd.Parameters.AddWithValue("@minStok", gminstok);
            cmd.Parameters.AddWithValue("@maliyet",gmaliyet);
            cmd.Parameters.AddWithValue("@id", gürünId);
            int etkilenen = cmd.ExecuteNonQuery();
            baglanti.Close();

            if (etkilenen == 0)
                throw new Exception("Güncellenecek ürün bulunamadı.");

        }
        public int stokGetir(int ürünId)
        {

            int stok = 0;

            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sql = "SELECT IFNULL(stok, 0) FROM ürün WHERE ürünId = @ürünId";

                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                {
                    cmd.Parameters.AddWithValue("@ürünId", ürünId);

                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != null && sonuc != DBNull.Value)
                        stok = Convert.ToInt32(sonuc);
                    else stok = 0;
                }
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }

            return stok;
        }

        public void stokDüş(int ürünId, int adet)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sql = "UPDATE ürün SET stok = stok - @adet WHERE ürünId = @ürünId";

                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@adet", adet);
                cmd.Parameters.AddWithValue("@ürünId", ürünId);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }



    }


}

