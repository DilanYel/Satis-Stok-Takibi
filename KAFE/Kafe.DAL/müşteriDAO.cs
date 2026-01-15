using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DAL
{
    public class müşteriDAO
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430037;User ID=26_132430037;Password=İnif123.;");

        public void MüşteriEkle(string müşteriAdı, string tür)
        {
            try
            {
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO müşteri (müşteriAdı, Tür) VALUES (@müşteriAd, @tür)", baglanti);

                cmd.Parameters.AddWithValue("@müşteriAd", müşteriAdı);
                cmd.Parameters.AddWithValue("@tür", tür);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }

        public DataTable MüşteriListele()
        {
            DataTable dt = new DataTable();
            try
            {
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT müşteriId, müşteriAdı, Tür FROM müşteri", baglanti);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }

        public void MüşteriSil(int id)
        {
            try
            {
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM müşteri WHERE müşteriId=@id", baglanti);

                cmd.Parameters.AddWithValue("@id", id);

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
