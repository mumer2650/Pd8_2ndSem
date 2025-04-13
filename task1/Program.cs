using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff("Hassan", "Lahore", "School", 10);
            staff.setName("Ali");
            Console.WriteLine($"{staff.toString()}");
        }
    }
}
