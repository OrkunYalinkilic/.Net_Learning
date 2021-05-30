using System;
using System.Collections; /**/
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack S1 = new Stack();

            S1.Push("Bir");
            S1.Push("Iki");
            S1.Push("Uc");
            S1.Push("Dort");

            object o1 = S1.Pop();
            int i1 = S1.Count;

            object o2 = S1.Peek();
            int i2 = S1.Count;

        }
    }
}
