using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP_Demo.Encapsulation
{
    internal struct Phonebook
    {
        #region Attributes
        string[] names;
        ulong[] numbers;
        private int size;
        #endregion

        //public long getnum(string name)
        //{
        //    if (name is not null && numbers is not null)
        //    {

        //        for (int i = 0; i < size; i++)
        //        {
        //            if (names[i] == name) return (long)numbers[i];
        //        }
                
        //    }
        //    return -1;
        //}
        
        //public void setnum(string name, ulong value)
        //{
        //    if(numbers is not null && names is not null)
        //    {
        //        for(int i = 0;i < size; i++)
        //        {
        //            if(name == names[i])
        //            {
        //                numbers[i] = value; //update
        //                return;
        //            }
        //        }
        //    }
        //}

        //indexer is a special property that named with "this" keyword and can take parameters
        public long this[string name]
        {
            get
            {
                if (name is not null && numbers is not null)
                {

                    for (int i = 0; i < size; i++)
                    {
                        if (names[i] == name) return (long)numbers[i];
                    }

                }
                return -1;
            }
            set
            {
                if (numbers is not null && names is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = (ulong) value; //update
                            return;
                        }
                    }
                }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"Position: {index+1}, Name: {names[index]}, Number = {numbers[index]}";
            }
        }

        #region Properties
        public int Size { 
            get
            {
                return size;
            }
        } 
        #endregion

        #region Constructor
        public Phonebook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new ulong[size];
        }
        #endregion

        #region Methods
        public void addperson(uint pos, string name, ulong number)
        {
            if (names is not null && numbers is not null && pos < size)
            {
                names[pos] = name;
                numbers[pos] = number;
            }
        } 
        #endregion
    }
}
