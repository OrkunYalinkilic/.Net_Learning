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
            //debugger modunda inceleyebilirisn. 
            try
            {
                //normal kodlarımız

                throw new FormatException("Format Hatasi");
                //throw new FormatException("Başka bir hata");
            }

            catch (FieldAccessException fex) when (fex.Message == "Field Hatasi")
            {
                Console.WriteLine(fex.Message);
            }

            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
