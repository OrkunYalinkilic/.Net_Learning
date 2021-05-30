using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int sayi;
            //    Console.WriteLine("Sayi giriniz:");
            //    sayi = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata olustu");
            //    Console.WriteLine(ex.Message);
            //}

            //--------------------------------

            //try
            //{
            //    int sayi;
            //    Console.WriteLine("Sayi giriniz:");
            //    sayi = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException fx)
            //{
            //    Console.WriteLine("Sayi girmelisiniz.");
            //    Console.WriteLine(fx.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Herhangi bir hata olustu");
            //    Console.WriteLine(ex.Message);
            //}

            ////---------------------------------------

            try
            {
                int sayi;
                Console.WriteLine("Sayi giriniz:");
                sayi = int.Parse(Console.ReadLine());

                if (sayi == 10)
                {
                    throw new OzelHataSinifi();
                }

            }
            catch (OzelHataSinifi ox)
            {
                Console.WriteLine("Ozel hata sinifi yakalandı.");
                Console.WriteLine(ox.Message);
            }

            catch (FormatException fx)
            {
                Console.WriteLine("Sayi girmelisiniz.");
                Console.WriteLine(fx.Message);
            }

            catch (Exception)
            {
                throw;
            }

            Console.ReadLine(); 
        }
    }
}
