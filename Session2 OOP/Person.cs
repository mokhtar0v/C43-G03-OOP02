using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session2_OOP
{
    internal struct Person
    {
        string[] names;
        public int[] ages;
        private int number;
        public int Size { get { return number; } }
        
        public string this[int index]
        {
            get
            {
                return $"Index = {index + 1}, Name: {names[index]},Age = {ages[index]}";
            }
        }
        public Person(int numner)
        {
            this.number = numner;
            names = new string[numner];
            ages = new int[numner];
        }
        
        public void addperson(uint pos, string name, int age)
        {
            if (names is not null && ages is not null && pos < number)
            {
                names[pos] = name;
                ages[pos] = age;

            }
        }
    }
}
