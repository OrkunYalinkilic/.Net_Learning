using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hesaplar
    {

        public decimal ortalama(decimal not1, decimal not2, decimal not3 = 40, decimal not4 = 50)
        {

            return (not1 + not2 + not3 + not4) / 4;
        }

    }
}
