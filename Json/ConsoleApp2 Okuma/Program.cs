using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Okuma
{
    class Program
    {
        static void Main(string[] args)
        { // json kütüphanesini tekrardan dahil ettim.

            string OkunanJsonOkunanData = File.ReadAllText("d:\\JSonIslemlerim\\Personellerim.json");

            List<XObject> data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(OkunanJsonOkunanData);

            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }

            Console.ReadLine();
        
        
        }
    }
}
