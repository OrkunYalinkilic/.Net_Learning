using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Musteri
    {
        private string tc_kimlikNo;

        public string Tc_kimlikNo
        {
            get
            {
                return this.tc_kimlikNo.Substring(0, 3);
            }

            set
            {
                if (value.Length != 11)
                {
                    Console.Write("TC kimlik no 11 haneden olusmalidir..");
                }

                else
                {
                    bool numberKontrol = true;

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsNumber(value[i]) == false)
                        {
                            numberKontrol = false;
                            break;
                        }
                    }

                    if (numberKontrol == false)
                    {
                        Console.Write("Tc kimlik no rakamlardan olusmalidir..");
                    }

                    else
                    {
                        this.tc_kimlikNo = value;
                    }
                }
            }
        }

    }
}
