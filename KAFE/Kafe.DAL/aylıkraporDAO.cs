using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DAL
{
    public class aylıkraporDAO
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430037;User ID= 26_132430037; Password=İnif123.;");

        public (decimal toplamCiro, int satışSayısı) AylikÖzetGetir(DateTime başlangıç, DateTime bitiş)
        {
            decimal toplamCiro = 0;
            int satışSayısı = 0;
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                string sql = @"SELECT IFNULL(SUM(tutar), 0) AS toplamCiro,COUNT(*) AS satışSayısı FROM satışlar WHERE tarih >= @başlangıç AND tarih < @bitiş; ";

                using (MySqlCommand cmd = new MySqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@başlangıç", başlangıç);
                    cmd.Parameters.AddWithValue("@bitiş", bitiş);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            toplamCiro = Convert.ToDecimal(dr["toplamCiro"]);
                            satışSayısı = Convert.ToInt32(dr["satışSayısı"]);
                        }
                    }
                }

            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }

            return (toplamCiro, satışSayısı);
        }
        public DataTable aylıkençoksatılanlar(DateTime başlangıç, DateTime bitiş)
        {
            DataTable dt = new DataTable();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sql = @" SELECT ürünAdı, SUM(adet) AS toplamAdet FROM satışlar WHERE tarih >= @başlangıç AND tarih < @bitiş GROUP BY ürünAdı  ORDER BY toplamAdet DESC LIMIT 5;  ";
                using (MySqlCommand cmd = new MySqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@başlangıç", başlangıç);
                    cmd.Parameters.AddWithValue("@bitiş", bitiş);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }

            return dt;



        }
        public (decimal toplamMaliyet, decimal karZarar) AylıkMaliyetVeKarZararGetir(DateTime başlangıç, DateTime bitiş)
        {
            decimal toplamMaliyet = 0;
            decimal karZarar = 0;
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sql = @"SELECT IFNULL(SUM(u.maliyet * s.adet), 0) AS toplamMaliyet,IFNULL(SUM((s.fiyat - u.maliyet) * s.adet), 0) AS karZarar FROM satışlar s JOIN ürün u ON u.ürünId = s.ürünId WHERE s.tarih >= @başlangıç AND s.tarih < @bitiş;";

                using (MySqlCommand cmd = new MySqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@başlangıç", başlangıç);
                    cmd.Parameters.AddWithValue("@bitiş", bitiş);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            toplamMaliyet = Convert.ToDecimal(dr["toplamMaliyet"]);
                            karZarar = Convert.ToDecimal(dr["karZarar"]);
                        }
                    }
                }
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }

            return (toplamMaliyet, karZarar);

        }

    }
}
