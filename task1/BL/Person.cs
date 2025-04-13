using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Person
    {
        protected string name;
        protected string address;

        public Person(string n,string a)
        {
            name = n;
            address = a;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string n)
        {
            name = n;
        }
        public string getAddress()
        {
            return address;
        }

        public void setAddress(string a)
        {
            address = a;
        }
        public string toString()
        {
            return $"Person [ Name = {name} , Address = {address}]";
        }
    }
}
