using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OzelHataSinifi:Exception
    {
        public OzelHataSinifi()
        {
            Console.WriteLine("Özel Hata Sinifi Olustu");
        }
    }
}
