using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum musteriReturnValue
    {
        kayitBasarili = 717770001, // bu değerleri vermesek kendi default int değerleri var. 
        kayitBasarisiz = 717770002, // Silip görebilirsin..
        varolanMusteri = 717770003,
        parametreHatasi = 717770004,
        calismaZamaniHatasi = 717770005
    } 
}
