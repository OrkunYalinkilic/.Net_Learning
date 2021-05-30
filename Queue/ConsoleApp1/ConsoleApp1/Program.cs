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
            Queue Q1 = new Queue();

            Q1.Enqueue("bir");
            Q1.Enqueue("iki");
            Q1.Enqueue("uc");
            Q1.Enqueue("dort");

            object o1 = Q1.Dequeue();
             int i1 = Q1.Count;

            object o2 = Q1.Peek();
            int i2 = Q1.Count;


        }
    }
}
