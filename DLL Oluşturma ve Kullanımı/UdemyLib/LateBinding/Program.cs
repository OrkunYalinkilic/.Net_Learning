using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly Exec = Assembly.GetExecutingAssembly();
            Type T = Exec.GetType("LateBinding.Musteri");

            object MusteriInstance = Activator.CreateInstance(T);
            MethodInfo mi = T.GetMethod("MusteriIsimGetir");

            string[] parametrelerim = new string[2];
            parametrelerim[0] = "Orkun";
            parametrelerim[1] = "Yalinkilic";

            string gelenDeger = (string)mi.Invoke(MusteriInstance, parametrelerim);
            Console.WriteLine(gelenDeger);

            Console.ReadLine();
        }
    }
}
