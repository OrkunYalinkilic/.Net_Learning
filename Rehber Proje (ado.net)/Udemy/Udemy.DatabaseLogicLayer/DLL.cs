using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;

namespace Udemy.DatabaseLogicLayer //data temiz mi istediğimiz kriterlere uymuş mu gibi kontrolleri yapmayacağız.. // Gelen data içeri yazılır veya içerden data çekilir.
{
    public class DLL
    {
        SqlConnection con; // c#ile sql arasındaki bağlantıyı sağlar
        SqlCommand cmd; // sorguları sql e gönderir.
        SqlDataReader reader; // sqlden çekilen datanın c# da karşıladığımız nesnedir.
        int ReturnValues;

        public DLL()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-O9HL0H1\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True"); //. local machine // user Id=sa;password=1; 
        }

        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public int SistemKayitKontrol(Kullanici K)
        {
            try
            {
                BaglantiAyarla();
                cmd = new SqlCommand("select count(*) from Kullanici where KullaniciAdi= @KullaniciAdi and Sifre = @Sifre", con);
                cmd.Parameters.Add("@KullaniciAdi",SqlDbType.NVarChar).Value=K.KullaniciAdi;
                cmd.Parameters.Add("@Sifre",SqlDbType.NVarChar).Value=K.Sifre;
                cmd.ExecuteNonQuery();
                ReturnValues = (int)cmd.ExecuteScalar(); // executeScalar gelen tek datayı döner.
            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public int KayitEkle(Rehber R)
        {
            try
            {
                cmd = new SqlCommand("insert into Rehber(ID,isim,soyisim,telefonNumarasiI,telefonNumarasiII," +
                    "telefonNumarasiIII,EmailAdres,WebAdres,Adres,Aciklama) values(@ID, @isim, @soyisim, " +
                    "@telefonNumarasiI, @telefonNumarasiII, @telefonNumarasiIII, @EmailAdres, @WebAdres, " +
                    "@Adres, @Aciklama)", con);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = R.ID;
                cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = R.isim;
                cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = R.soyisim;
                cmd.Parameters.Add("@telefonNumarasiI", SqlDbType.NVarChar).Value = R.telefonNumarasiI;
                cmd.Parameters.Add("@telefonNumarasiII", SqlDbType.NVarChar).Value = R.telefonNumarasiII;
                cmd.Parameters.Add("@telefonNumarasiIII", SqlDbType.NVarChar).Value = R.telefonNumarasiIII;
                cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = R.EMailAdres;
                cmd.Parameters.Add("@WebAdres", SqlDbType.NVarChar).Value = R.WebAdres;
                cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = R.Adres;
                cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = R.aciklama;
                BaglantiAyarla(); // bağlantı açıldı
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiAyarla(); //bağlantı kapatıldı.
            }
            return ReturnValues;
        }

        public int KayitDuzenle(Rehber R)
        {
            try
            {
                cmd = new SqlCommand("update Rehber set isim=@isim,soyisim=@soyisim," +
                    "telefonNumarasiI=@telefonNumarasiI,telefonNumarasiII=@telefonNumarasiII," +
                    "telefonNumarasiIII = @telefonNumarasiIII, EmailAdres = @EmailAdres, WebAdres = @WebAdres, " +
                    "Adres = @Adres, Aciklama = @Aciklama where ID=@ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = R.ID;
                cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = R.isim;
                cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = R.soyisim;
                cmd.Parameters.Add("@telefonNumarasiI", SqlDbType.NVarChar).Value = R.telefonNumarasiI;
                cmd.Parameters.Add("@telefonNumarasiII", SqlDbType.NVarChar).Value = R.telefonNumarasiII;
                cmd.Parameters.Add("@telefonNumarasiIII", SqlDbType.NVarChar).Value = R.telefonNumarasiIII;
                cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = R.EMailAdres;
                cmd.Parameters.Add("@WebAdres", SqlDbType.NVarChar).Value = R.WebAdres;
                cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = R.Adres;
                cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = R.aciklama;
                BaglantiAyarla(); // bağlantı açıldı
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public int KayitSil(Guid id)
        {
            try
            {
                cmd = new SqlCommand("delete Rehber where ID=@ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = id;
                BaglantiAyarla(); // bağlantı açıldı
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public SqlDataReader KayitListe()
        {
            cmd = new SqlCommand("select *from Rehber", con);
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }

        public SqlDataReader KayitListeID(Guid id)
        {
            cmd = new SqlCommand("select *from Rehber where ID=@ID", con);
            cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = id;
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }

    }
}
