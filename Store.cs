using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreAppGUI
{
    class Store
    {
        public List<Car> Car_List { get; set; } //lista samochodow
        public List<Car> Shopping_List { get; set; }

        public List<Car> History_list { get; set; }

        public Store() //konstruktor - utworzenie 2 list
        {
            Car_List = new List<Car>();
            Shopping_List = new List<Car>();
            History_list = new List<Car>();
        }

        //metody
        public decimal Podsumowanie() //podliczenie zakupow w koszyku
        {
            decimal total_Cost = 0;

            foreach (var car in Shopping_List) //sumowanie kosztow
            {
                total_Cost = total_Cost + car.Price;
            }
            Shopping_List.Clear(); //wyczysc liste zakupow po podsumowaniu
            return total_Cost;
        }
    }
}
