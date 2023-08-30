using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Customer
    {
        private int ıd;
        private string name;
        private string surname;
        private string city;

        public int Id { get => ıd; set => ıd = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
    }
}
