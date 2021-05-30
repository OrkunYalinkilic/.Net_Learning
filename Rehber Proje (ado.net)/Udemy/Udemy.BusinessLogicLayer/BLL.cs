using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;

namespace Udemy.BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;

        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }

        public int SistemKayitKontrol(string KullaniciAdi, string Sifre)
        {
            if (!string.IsNullOrEmpty(KullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                return dll.SistemKayitKontrol(new Kullanici()
                {
                    KullaniciAdi = KullaniciAdi,
                    Sifre = Sifre
                });
            }
            else
            {
                return -1;
            }
        }

        public int KayitEkle(string isim, string soyisim, string telefonNumarasiI, string telefonNumarasiII, string telefonNumarasiIII, string EMailAdres, string WebAdres, string Adres, string Aciklama)
        {
            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(telefonNumarasiI))
            {
                return dll.KayitEkle(new Rehber()
                {
                    ID = new Guid(),
                    isim = isim,
                    soyisim = soyisim,
                    telefonNumarasiI = telefonNumarasiI,
                    telefonNumarasiII = telefonNumarasiII,
                    telefonNumarasiIII = telefonNumarasiIII,
                    WebAdres = WebAdres,
                    Adres = Adres,
                    EMailAdres = EMailAdres,
                    aciklama = Aciklama
                });
            }
            else
            {
                return -1; // Eksik parametre hatası
            }
        }

        public int KayitDuzenle(Guid ID, string isim, string soyisim, string telefonNumarasiI, string telefonNumarasiII, string telefonNumarasiIII, string EMailAdres, string WebAdres, string Adres, string Aciklama)
        {
            if (ID != Guid.Empty)
            {
                return dll.KayitDuzenle(new Rehber()
                {
                    ID = ID,
                    isim = isim,
                    soyisim = soyisim,
                    telefonNumarasiI = telefonNumarasiI,
                    telefonNumarasiII = telefonNumarasiII,
                    telefonNumarasiIII = telefonNumarasiIII,
                    WebAdres = WebAdres,
                    Adres = Adres,
                    EMailAdres = EMailAdres,
                    aciklama = Aciklama

                });
            }
            else
            {
                return -1;
            }
        }

        public int KayitSil(Guid id)
        {
            if (id != Guid.Empty)
            {
                return dll.KayitSil(id);
            }
            else
            {
                return -1;
            }
        }

        public List<Rehber> KayitListe()
        {
            List<Rehber> RehberListesi = new List<Rehber>();
            try
            {
                SqlDataReader reader = dll.KayitListe();
                while (reader.Read())
                {
                    RehberListesi.Add(new Rehber()
                    {
                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        telefonNumarasiI = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        telefonNumarasiII = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        telefonNumarasiIII = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        WebAdres = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Adres = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        EMailAdres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return RehberListesi;

        }

        public Rehber KayitListeID(Guid ID)
        {
            Rehber RehberKayit = new Rehber();
            try
            {
                SqlDataReader reader = dll.KayitListeID(ID);
                while (reader.Read())
                {
                    RehberKayit = new Rehber()
                    {
                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        telefonNumarasiI = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        telefonNumarasiII = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        telefonNumarasiIII = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        WebAdres = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Adres = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        EMailAdres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return RehberKayit;

        }

    }
}
