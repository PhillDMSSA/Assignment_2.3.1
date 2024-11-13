using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._3._1
{
    internal class Person
    {
        public Person(string firstname, string lastname, int age, string address)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Address = address;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }


    }
}
