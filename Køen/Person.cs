using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Person
    {
        private string name { get; set; }

        private int age { get; set; }

        public string Name 
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public Person() 
        { 

        }

    }
}
