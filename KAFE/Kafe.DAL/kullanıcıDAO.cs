using KAFE.Kafe.DOMAİN;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAFE.Kafe.DAL
{
    public class kullanıcıDAO
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430037;User ID= 26_132430037; Password=İnif123.;");
        public bool girişkontrol(string gkullAdı, string gkullŞifre)
        {
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT*FROM kullanıcı WHERE kullanıcıAdı='" + gkullAdı + "' AND kullanıcıŞifre='" + gkullŞifre + "'", baglanti);
            MySqlDataReader oku = cmd.ExecuteReader();
            bool sonuç = oku.Read();
            baglanti.Close();
            return sonuç;
        }
        public kullanıcı kullanıcıGetir(string gkullAdı, string gkullŞifre)
        {
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT*FROM kullanıcı WHERE kullanıcıAdı='" + gkullAdı + "' AND kullanıcıŞifre='" + gkullŞifre + "'", baglanti);
            MySqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                var k = new kullanıcı();
                k.kullanıcıId = Convert.ToInt32(oku["kullanıcıId"]);
                k.kullanıcıAdı = oku["kullanıcıAdı"].ToString();
                k.kullanıcıŞifre = oku["kullanıcıŞifre"].ToString();
                k.Rol = (kullanıcıRol)Enum.Parse(typeof(kullanıcıRol), oku["rol"].ToString());
                baglanti.Close();
                return k;
            }
            baglanti.Close();
            return null;
        }
        }   
}
