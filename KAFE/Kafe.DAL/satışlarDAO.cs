using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DAL
{
  public class satışlarDAO
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430037;User ID=26_132430037;Password=İnif123.;");

        public void satışEkle(int müşteriId, string müşteriAdı, int ürünId, string ürünAdı, int adet, decimal fiyat, decimal tutar)
        {
            try
            {
                baglanti.Open();

                string sql = @"INSERT INTO `satışlar`(`müşteriId`, `müşteriAdı`, `ürünId`, `ürünAdı`, `adet`, `fiyat`, `tutar`,`tarih`)VALUES (@müşteriId, @müşteriAdı, @ürünId, @ürünAdı, @adet, @fiyat, @tutar,@tarih);";
                using (MySqlCommand cmd = new MySqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@müşteriId", müşteriId);
                    cmd.Parameters.AddWithValue("@müşteriAdı", müşteriAdı);
                    cmd.Parameters.AddWithValue("@ürünId", ürünId);
                    cmd.Parameters.AddWithValue("@ürünAdı", ürünAdı);
                    cmd.Parameters.AddWithValue("@adet", adet);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@tutar", tutar);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }

        public DataTable satışlarıGetir()
        {
            var dt = new DataTable();

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                string sql = @"SELECT`id`,`müşteriId`,`müşteriAdı`,`ürünId`,`ürünAdı`,`adet`, `fiyat`,`tutar`,`tarih`FROM `satışlar` ORDER BY `id` DESC;";
                using (var da = new MySqlDataAdapter(sql, baglanti))
                {
                    da.Fill(dt);
                }
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
            return dt;




        }
    }
}
