using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2_OOP
{
    internal class Hiring_Date
    {
        public int date {  get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public Hiring_Date(int _date, int _month, int _year)
        {
            date = _date;
            year = _year;
            month = _month;
        }
    }
}
