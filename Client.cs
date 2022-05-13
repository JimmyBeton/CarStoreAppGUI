using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreAppGUI
{
    class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Order_ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public decimal Order_cost { get; set; }
        public List<Client> orderslist = new List<Client>();

        public Client()
        {
            Name = "none";
            Surname = "none";
            //Order_ID = "none";
            Street = "none";
            City = "none";
            Country = "none";
            //Order_cost = 0.00M;
        }

        public Client(string a, string b,string c, string d, string f,string g)
        { //decimal e ; string c
            Name = a;
            Surname = b;
            Order_ID = c;
            Street = d;
            City = f;
            Country = g;
            //Order_cost = e;
        }

        public override string ToString()
        {
            return Order_ID + ";" + Name + ";" + Surname + ";" + "(" + Street+";"+City+";"+Country + ")";
        }

    }
}
