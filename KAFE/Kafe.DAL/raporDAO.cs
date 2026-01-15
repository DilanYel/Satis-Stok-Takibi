using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DAL
{
    public class raporDAO
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430037;User ID= 26_132430037; Password=İnif123.;");

        public DataTable minimumStokGetir()
        {
            DataTable dt = new DataTable();

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                string sql = @" SELECT ürünadı, stok, (minstok - stok) AS eksikMiktar FROM ürün WHERE stok < minstok ORDER BY (minstok - stok) DESC;";

                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
            return dt;

        }

        public DataTable günlükSatışGetir(DateTime tarih)
        {
            DataTable dt = new DataTable();
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DateTime başlangıç = tarih.Date;
                DateTime bitiş = başlangıç.AddDays(1);
                string sql = @" SELECT`ürünAdı`,`adet`,`tutar` FROM `satışlar`WHERE `tarih` >= @baslangic AND `tarih` < @bitis  ORDER BY `tarih` ASC;";
                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@baslangic", başlangıç);
                cmd.Parameters.AddWithValue("@bitis", bitiş);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            return dt;
        }

        public decimal günlükToplamCiroGetir(DateTime tarih)
        {
            decimal toplamCiro = 0;
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                DateTime başlangıç = tarih.Date;
                DateTime bitiş = başlangıç.AddDays(1);
                string sql = @"
            SELECT IFNULL(SUM(`tutar`), 0) FROM `satışlar` WHERE `tarih` >= @başlangıç AND `tarih` < @bitiş;";

                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@başlangıç", başlangıç);
                cmd.Parameters.AddWithValue("@bitiş", bitiş);

                object sonuc = cmd.ExecuteScalar();

                if (sonuc != null && sonuc != DBNull.Value)
                    toplamCiro = Convert.ToDecimal(sonuc);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            return toplamCiro;
        }
        public int toplamÜrünadediGetir(DateTime tarih)
        {
            int toplamAdet = 0;
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                DateTime başlangıç = tarih.Date;
                DateTime bitiş = başlangıç.AddDays(1);
                string sql = @"SELECT IFNULL(SUM(`adet`), 0) FROM `satışlar` WHERE `tarih` >= @başlangıç AND `tarih` < @bitiş;";

                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@başlangıç", başlangıç);
                cmd.Parameters.AddWithValue("@bitiş", bitiş);

                object sonuc = cmd.ExecuteScalar();
                if (sonuc != null && sonuc != DBNull.Value)
                    toplamAdet = Convert.ToInt32(sonuc);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            return toplamAdet;
        }
        public int günlüksiparişsayısıGetir(DateTime tarih)
        {
            int siparişsayısı = 0;
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                DateTime başlangıç = tarih.Date;
                DateTime bitiş = başlangıç.AddDays(1);

                string sql = @" SELECT COUNT(*)FROM `satışlar` WHERE `tarih` >= @başlangıç AND `tarih` < @bitiş;";

                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@başlangıç", başlangıç);
                cmd.Parameters.AddWithValue("@bitiş", bitiş);

                object sonuc = cmd.ExecuteScalar();

                if (sonuc != null && sonuc != DBNull.Value)
                    siparişsayısı = Convert.ToInt32(sonuc);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            return siparişsayısı;

        }
        public DataTable müşteribazlıraporlarıListele(DateTime tarih)
        {
            DataTable dt = new DataTable();
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

               
                DateTime başlangıç = tarih.Date;
                DateTime bitiş = başlangıç.AddDays(1);

                string sql = @" SELECT müşteriAdı AS 'Müşteri', IFNULL(SUM(tutar), 0) AS 'Toplam Ciro'  FROM satışlar  WHERE tarih >= @başlangıç AND tarih < @bitiş GROUP BY müşteriAdı ORDER BY SUM(tutar) DESC; ";

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
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

            return dt;

        }
        public DataTable ençoksatılanürünGetir(DateTime tarih)
        {
            DataTable dt = new DataTable();
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                DateTime başlangıç = tarih.Date;
                DateTime bitiş = başlangıç.AddDays(1);

                string sql = @" SELECT  ürünAdı AS 'ürün', IFNULL(SUM(adet), 0) AS 'Toplam Adet' FROM satışlar WHERE tarih >= @başlangıç AND tarih < @bitiş GROUP BY ürünAdı ORDER BY SUM(adet) DESC LIMIT 3 ";

                using (var cmd = new MySqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@başlangıç", başlangıç);
                    cmd.Parameters.AddWithValue("@bitiş", bitiş);

                    using (var da = new MySqlDataAdapter(cmd))
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

