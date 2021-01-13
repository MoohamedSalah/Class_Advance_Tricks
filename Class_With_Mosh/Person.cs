using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_With_Mosh
{
    public class Person
    {
        public  string name;
        public void Hallo(string my)
        {
            Console.WriteLine($"Hallo {name},my name is {my}");
        }
        public  static   Person PersonName(string n)
        {
            var p = new Person();
            p.name = n;
            return p;
        }
    
    }
}
