using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Person
    {
        //PROPERTIES
        private string Name { get; set; }
        private string Address { get; set; }

        //CONSTRUCTOR
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public Person()
        {
            Name = "";
            Address = "";
        }

        //OVERRIDES
        public override string ToString()
        {
            return $"Person[Name = {Name}, Address = {Address}]";
        }
    }
}
