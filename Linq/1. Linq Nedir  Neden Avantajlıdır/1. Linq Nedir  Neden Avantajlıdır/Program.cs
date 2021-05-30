using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Linq_Nedir__Neden_Avantajlıdır
{
    class Program
    {
        static bool funcDelegateKullanimi1(Musteri M)
        {
            if (M.isim[0] == 'A')
                return true;
            else
                return false;
        }

        static bool predicateDelegateMetot(Musteri M)
        {
            if (M.dogumTarih.Year > 1990)
                return true;
            else
                return false;
        }

        static void musteriListele(Musteri m)
        {

            Console.WriteLine(m.isim + " " + m.soyisim);

        }


        static void Main(string[] args)
        {

            dataSource ds = new dataSource();
            List<Musteri> musteriliste = ds.musteriListesi();


            #region Linq İnceleme ve Ara Ödevler 

            //Musteri listesi icerisinde bulunan kayıtlardan ismi a ile başlayan sıyisiminde e olan ve dogum yılı 1985 den 
            // buyuk olan kayıtları getirin.

            var odevAlistirma1 = musteriliste.Where(i => i.isim.StartsWith("A") && i.soyisim.Contains("e") && i.dogumTarih.Year > 1985).Select(i => i);
            Console.WriteLine(odevAlistirma1.Count());

            var odevAlistirma2 = from I in musteriliste
                                 where I.isim.StartsWith("A") &&
                                 I.soyisim.Contains("e") &&
                                 I.dogumTarih.Year > 1985
                                 select I;
            Console.WriteLine(odevAlistirma2.Count());




            #endregion

            #region Action Delegate

            Action<Musteri> actionMusteri = new Action<Musteri>(musteriListele);
            musteriliste.ForEach(actionMusteri);

            musteriliste.ForEach(new Action<Musteri>(musteriListele));

            musteriliste.ForEach(delegate (Musteri m) { Console.WriteLine(m.isim + " " + m.soyisim); });

            musteriliste.ForEach((Musteri m) => { Console.WriteLine(m.isim + " " + m.soyisim); });

            musteriliste.ForEach((m) => { Console.WriteLine(m.isim + " " + m.soyisim); });  // En fazla bu kadar kısaltılabiliyor.
            // Sadece listeleme değil bir çok işlem yapılabir.Şimdilik bunu yaptık.

            #endregion

            #region Linq Sorgularında Delegate kullanımı = Predicate Delegate
            //Predicate delegate geriye her zaman bool döner. Func her zaman bool dönmez.

            Predicate<Musteri> predicate = new Predicate<Musteri>(predicateDelegateMetot);

            var delegateKullanimiPredicate1 = musteriliste.FindAll(predicate);

            var delegateKullanimiPredicate2 = musteriliste.FindAll(new Predicate<Musteri>(predicateDelegateMetot));

            var delegateKullanimiPredicate3 = musteriliste.FindAll(delegate (Musteri m) { return m.dogumTarih.Year > 1990; });

            var delegateKullanimiPredicate4 = musteriliste.FindAll((Musteri m) => { return m.dogumTarih.Year > 1990; });

            var delegateKullanimiPredicate5 = musteriliste.FindAll((m) => { return m.dogumTarih.Year > 1990; });

            var delegateKullanimiPredicate6 = musteriliste.FindAll(m => m.dogumTarih.Year > 1990);

            #endregion

            #region Linq Sorgularında Delegate kullanımı = Func Delegate

            // => kullanarak sorgulama
            var delegateKullanimi1 = musteriliste.Where(I => I.isim.StartsWith("A"));

            // => kullanmadan func delegate ile sorgulama(=> lambdanın yaptığı işi uzun yoldan yapar.
            // overload kısmına bakarak istenilen delegate ve fonksiyonları vs. oluşturduk.

            Func<Musteri, bool> funcdelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);

            var delegateKullanimi2 = musteriliste.Where(funcdelegate1);

            //delegateKullanimi2 = musteriliste.Where(funcDelegateKullanimi1) aynı işi yaparlar.(delegate kullanmadan)

            // Yani where bizden bir func delege istiyor. Onun yerine lambda ile işaret edeceği yeri de verebiliyoruz.
            // İşin sonunda çoğunlukla => kullanacağız.

            var delegateKullanimi3 = musteriliste.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));
            // Bu şekilde dışarıda tanımlamak yerine new anahtar kelimesi sayseinde içerde de tanımlayabilrz 

            var delegateKullanimi4 = musteriliste.Where(delegate (Musteri m) { return m.isim[0] == 'A' ? true : false; });

            var delegateKullanimi5 = musteriliste.Where((Musteri m) => { return m.isim[0] == 'A' ? true : false; });

            var delegateKullanimi6 = musteriliste.Where((m) => { return m.isim[0] == 'A' ? true : false; });

            var delegateKullanimi7 = musteriliste.Where(m => m.isim[0] == 'A');  // =>

            //Belki hiç bir zaman karşılaşmayacağım ama ola ki => nın çözemediği bir şey oldu. O zaman bunlar işe 
            //yarayabilir.

            #endregion

            #region Alistirmalar

            // 1: MUsteriler icerisinde ulke degeri A ile baslayan musterileri Linq metot kullanarak bulalım.

            IEnumerable<Musteri> musteriListeAlistirma1 = musteriliste.Where(i => i.ulke.StartsWith("A"));
            // where üzerine gelinirse IEnumerable old görülebilir.
            Console.WriteLine(musteriListeAlistirma1.Count());

            // 2: Musteriler listesinde kayıtlarda isminin icinde b harfi gecen ve ulke degeri icinde a harfi gecen
            //musterilerin listesini getirin. &&

            IEnumerable<Musteri> musteriListeAlistirma2 = musteriliste.Where(I => I.isim.Contains("a") && I.ulke.Contains("a")).ToList();
            // Genelde list degilde var anahtar kelimesi uzerinden alınır. Sonra onun üzerinde islemler yapılır.

            // 3: Musteriler listesi icerisindeki kayıtlardan dogum yılı 1990 dan buyuk olan ve isminin icersinde a harfi
            // gecen musterileri 2.yol olan Linq to Query ile bulalım.

            var musteriListeAlistirma3 = from I in musteriliste
                                         where
                                         I.dogumTarih.Year > 1990 && I.isim.Contains("a")
                                         select I;
            Console.WriteLine(musteriListeAlistirma3.Count());

            // 4: Musteriler listesi icerisindeki kayıtlardan dogum yılı 1990 dan buyuk olan veya isminin icersinde a harfi
            // gecen musterileri 2.yol olan Linq to Query ile bulalım.

            var musteriListeAlistirma4 = from I in musteriliste
                                         where I.dogumTarih.Year > 1990 || I.isim.Contains("a")
                                         select I;
            #endregion

            #region Linq Sorgulama Çeşitleri

            // I.YOL

            int toplamMusteriAdet = musteriliste.Where(I => I.isim.StartsWith("A")).Count();

            // II.YOL
            var toplamMusteriBulunan = (from I in musteriliste
                                        where I.isim.StartsWith("A")
                                        select I);
            //Burası bana bir generic liste döner.

            int toplamMusteriAdet2 = toplamMusteriBulunan.Count();

            #endregion

            #region Baslarken

            // A ile başlayan müşterilerin adedini verin. 
            int bulunanToplam = 0;
            for (int i = 0; i < musteriliste.Count; i++)
            {
                if (musteriliste[i].isim[0] == 'A')
                {
                    bulunanToplam++;
                }
            }
            Console.WriteLine("A ile baslayan: " + bulunanToplam);

            Console.WriteLine(musteriliste.Count);

            bulunanToplam = 0;

            bulunanToplam = musteriliste.Where(i => i.isim.StartsWith("A")).Count();
            Console.WriteLine("A ile baslayan: " + bulunanToplam);
            // burada where ile linq belirli kritere göre arama yapmamızı sağlayarak development 'ı hızlandırdı.
            // i musteriListesine aittir. Ve onun içerisinde geziyor. isim baslangıcı a olan degerleri
            // alıyor. en sonunda biz de count ile onun sayısını ogrenmis oluyoruz.

            #endregion

            Console.ReadLine();
        }
    }
}
