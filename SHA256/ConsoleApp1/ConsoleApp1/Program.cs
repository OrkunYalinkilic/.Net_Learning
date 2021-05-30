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
            string text1 = "Orkun Yalinkilic";
            string sifreliText1 =  SHA.SHA256Sifrele(text1);
        }
    }
}
