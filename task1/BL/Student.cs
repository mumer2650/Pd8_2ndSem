using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name,string address,string p,int y,double f) : base(name,address)
        {
            program = p;
            year = y;
            fee = f;
        }

        public string getProgram()
        {
            return program;
        }
        public void setProgram(string p)
        {
            program = p;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int y)
        {
            year = y;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double f)
        {
            fee = f;
        }
        public new string toString() 
        {
            return $"Student [ {base.toString()} Program = {program} , Year = {year} , fee = {fee}]"; 
        }
    }
}

