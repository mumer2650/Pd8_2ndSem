using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Staff : Person
    {
        private string school;
        private double pay;

        public Staff(string n,string a,string school,double pay) : base(n, a)
        {
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return school;
        }

        public void setSchool(string school)
        {
            this.school = school;
        }

        public double getPay()
        {
            return pay;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public new string toString()
        {
            return $"Staff [ {base.toString()}  School = {school} , Pay = {pay}]";
        }
    }
}
