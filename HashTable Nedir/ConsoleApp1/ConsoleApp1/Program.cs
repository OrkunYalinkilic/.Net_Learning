using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Debugger modunda incele..
            Hashtable H1 = new Hashtable();

            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");
            H1.Add("Cars", "Araba");

            bool kontrol1 = H1.Contains("Car");
            bool kontrol2 = H1.Contains("Pen");

            bool kontrol3 = H1.ContainsKey("Cars");
            bool kontrol4 = H1.ContainsKey("Laptop");


            bool kontrol5 = H1.ContainsValue("Ev");
            bool kontrol6 = H1.ContainsValue("Villa");

            int uzunluk = H1.Count;

            H1.Remove("Car");

            H1["Cars"] = "Arabalar";

            H1.Clear();

 
        }
    }
}
