using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Student:Person
    {
        //PROPERTIES
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        //CONSTRUCTOR
        public Student(string name, string address, string program, int year, double fee): base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public Student(): base()
        {
            Program = "";
            Year = 0;
            Fee = 0;
        }

        //OVERRIDES
        public override string ToString()
        {
            return $"Student[{base.ToString()}, Program = {Program}, Year = {Year}, Fee = {Fee}]";
        }
    }
}
