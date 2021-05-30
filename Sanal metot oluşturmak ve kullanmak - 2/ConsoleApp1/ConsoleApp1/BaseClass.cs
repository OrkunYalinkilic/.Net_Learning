using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class baseClass
    {
        public string isim { get; set; }
        public string soyisim { get; set; }


        public virtual void ekranaYaz(string data)
        {
            Console.WriteLine(data);
        }

    }
}
