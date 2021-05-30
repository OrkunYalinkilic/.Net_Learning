using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arLi = new ArrayList();
            int secim;
            int secim2=0;

            do
            {
                Console.WriteLine("\tMENÜ");
                Console.WriteLine("----------------------");
                Console.WriteLine("1.Değer Ekle");
                Console.WriteLine("2.Değerleri Listele");
                Console.WriteLine("3.Değer Ara");
                Console.WriteLine("4.Değer Düzenle");
                Console.WriteLine("5.Değer Sil");
                Console.WriteLine("0.Çıkış");
                Console.Write("\nSeciminiz: ");
                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 0:
                        {
                            Console.ReadLine();
                        }

                    case 1:
                        {
                            Console.Clear();

                            string eklenecekDeger = string.Empty;
                            Console.Write("Eklemek Istediginiz Degeri Giriniz: ");
                            eklenecekDeger = Console.ReadLine();
                            arLi.Add(eklenecekDeger);
                            Console.WriteLine("Deger basariyla eklendi..");
                            Console.Write("\nBir ust menuye donmek icin 9'u tuslayiniz..");

                            secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();

                            Console.WriteLine("DEGERLERİN LİSTESİ");
                            for (int i = 0; i < arLi.Count; i++)
                            {
                                Console.WriteLine("{0}. {1}", i + 1, arLi[i]);
                            }
                            Console.Write("\nBir ust menuye donmek icin 9'u tuslayiniz..");
                            secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();

                            Console.Write("Aradiginiz degeri giriniz: ");
                            string aranan = Console.ReadLine();

                            bool arananKontrol = arLi.Contains(aranan);
                            int arananIndex = arLi.IndexOf(aranan);

                            if (arananKontrol == true)
                            {
                                Console.WriteLine("Aramis oldugunuz deger kayitlarda basariyla bulunmustur..");
                                Console.WriteLine("Deger ismi: " + arLi[arananIndex]);
                                Console.WriteLine("Değer sirasi: {0}", arananIndex + 1);
                            }
                            else
                            {
                                Console.WriteLine("Aramis oldugunuz deger bulunamamistir..");
                            }

                            Console.Write("\nBir ust menuye donmek icin 9'u tuslayiniz..");
                            secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();

                            Console.Write("Duzenlemek istediginiz degerin adini giriniz:");
                            string duzenlenecek = Console.ReadLine();
                            bool duzenlenecekKontrol = arLi.Contains(duzenlenecek);
                            int duzenlenecekIndex = arLi.IndexOf(duzenlenecek);

                            if (duzenlenecekKontrol == false)
                            {
                                Console.WriteLine("Belirttiginiz deger bulunamamistir..");
                            }
                            else
                            {
                                Console.Write(duzenlenecek + "yerine gelmesi istediginiz degeri giriniz:");
                                string duzenlenecek2 = Console.ReadLine();

                                arLi[duzenlenecekIndex] = duzenlenecek2;
                                Console.WriteLine(value: "Belirttiginiz degisiklik basariyla guncellenmistir..");

                            }

                            Console.Write("\nBir ust menuye donmek icin 9'u tuslayiniz..");
                            secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();

                            Console.Write("Silmek istediginiz degeri giriniz:");
                            string silinecek = Console.ReadLine();

                            if (arLi.Contains(silinecek) == false)
                            {
                                Console.WriteLine("Silinmesi istediginiz " + silinecek + " isimli deger bulunamamistir..");
                            }
                            else
                            {
                                arLi.Remove(silinecek);
                                Console.WriteLine("Silme islemi basariyla gerceklesmistir..");
                            }

                            Console.Write("\nBir ust menuye donmek icin 9'u tuslayiniz..");
                            secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            break;
                        }

                 
                 

                        //default:

                }
            } while (secim2 == 9);

        }
    }
}
