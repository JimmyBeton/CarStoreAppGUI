using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreAppGUI
{
    class Car
    {
        //properties
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public string Country { get; set; }

        public string Vintage { get; set; }

        public Car() //defaultowy konstruktor - przypisuje wartosci domyslne jesli nie sa podane
        {
            Marka = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M; //M - sufiks
            Country = "none";
            Vintage = "none";
        }
        public Car(string a, string b, decimal c, string d, string e) // konstruktor do przypisania konkretnych
        {                                         // wartosci
            Marka = a;
            Model = b;
            Price = c;
            Country = d;
            Vintage = e;
        }

        //napdpisanie metody ToString, zeby prawidlowo wyswietlac w listboxie
        override public string ToString()
        {
            return Marka + ";" + Model + ";" + Price + ";" + Country + ";" + Vintage;
        }
    }
}
