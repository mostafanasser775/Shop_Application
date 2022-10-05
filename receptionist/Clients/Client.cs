using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Application.receptionist.Clients
{
    internal class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Age { get; set; }
        public string Whatsup { get; set; }
        public string Whatsup1 { get; set; }
        public string Whatsup2 { get; set; }
        public string Notes { get; set; }

        public Client(string name, string phone, string phone1, string phone2, string city, string location, string age, string whatsup, string whatsup1, string whatsup2, string notes)
        {
            Name = name;
            Phone = phone;
            Phone1 = phone1;
            Phone2 = phone2;
            City = city;
            Location = location;
            Whatsup = whatsup;
            Whatsup1 = whatsup1;
            Whatsup2 = whatsup2;
            Notes = notes;
        }
    }
}
