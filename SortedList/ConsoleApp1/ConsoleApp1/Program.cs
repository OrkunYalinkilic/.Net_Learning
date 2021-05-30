using System;
using System.Collections; /***/
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sorLi = new SortedList();

            sorLi.Add(100, "Yüz");
            sorLi.Add(350, "Ucyuz");
            sorLi.Add(0, "sifir");
            sorLi.Add(1000, "bin");
            sorLi.Add(-20, "eksi yirmi");

            foreach (var item in sorLi.Keys)
            {
                Console.WriteLine(item + "=" + sorLi[item]);
            }

        }
    }
}
