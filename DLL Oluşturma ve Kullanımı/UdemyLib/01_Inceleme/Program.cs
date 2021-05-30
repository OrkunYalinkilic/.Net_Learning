using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //C: \Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\100-) DLL Oluşturma ve Kullanımı\UdemyLib\UdemyLib\bin\Debug\netstandard2.0\UdemyLib.dll

            Assembly Lib = Assembly.LoadFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\100-) DLL Oluşturma ve Kullanımı\UdemyLib\UdemyLib\bin\Debug\netstandard2.0\UdemyLib.dll");
            Type[] TP = Lib.GetTypes();

            foreach (Type item in TP)
            {
                ConstructorInfo[] CTORS =  item.GetConstructors();
                for (int i = 0; i < CTORS.Length; i++)
                {
                    Console.WriteLine(CTORS[i].ToString());
                }

                PropertyInfo[] PRP = item.GetProperties();
                for (int i = 0;  i< PRP.Length; i++)
                {
                    Console.WriteLine("isim:" + PRP[i].Name + " Namespace: " + item.Namespace + " Public: " + item.IsPublic + " Tam Adi: " + item.FullName);
                }


                MethodInfo[] MTH = item.GetMethods();

                for (int i = 0; i < MTH.Length; i++)
                {
                    Console.WriteLine("Metot Adi: " + MTH[i].Name);
                }
                
                
                Console.ReadLine();
            
            
                // HATIRLATMA: Virtual metotlarımızı biz override ile ezebiliyorduk..
            
            
            }
        }
    }
}
