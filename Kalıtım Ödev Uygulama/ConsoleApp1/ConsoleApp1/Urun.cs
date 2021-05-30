using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Urun : BaseClass
    {

        public string marka { get; set; } /* Belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin. */
        public string model { get; set; }

        private decimal _alisFiyati;
        public decimal alisFiyati
        {
            get
            {
                return this._alisFiyati;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Alis Fiyati 0'dan küçük olamaz!");
                }

                else
                {
                    this._alisFiyati = value;
                }
            }
        } /* 0'dan küçük olmamalı. */

        private decimal _satisFiyati;
        public decimal satisFiyati
        {
            get
            {
                return this._satisFiyati;
            }
            set
            {
                if (value < this._alisFiyati)
                {
                    Console.WriteLine("Satis fiyati Alis Fiyatindan kücük olamaz!");
                }
                else
                {
                    this._satisFiyati = value; 
                }
            }
        } /* Alış fiyatından küçük olmamalı. */

        private decimal _kampanyaFiyati;
        public decimal kampanyaFiyati
        {
            get
            {
                return this._kampanyaFiyati;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Kampanya Fiyati 0'dan kücük olamaz!");
                }
                else
                {
                    this._kampanyaFiyati = value;
                }
            }
        } /* 0'dan küçük olmamalı. */

    }
}
