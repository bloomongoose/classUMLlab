using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Staff:Person
    {
        //PROPERTIES
        private string School { get; set; }
        private double Pay { get; set; }

        //CONSTRUCTOR
        public Staff (string name, string address, string school, double pay):base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public Staff() : base()
        {
            School = "";
            Pay = 0;
        }

        //OVERRIDES
        public override string ToString()
        {
            return $"Staff[{base.ToString()}, School = {School}, Pay = {Pay}]";
        }
    }
}
