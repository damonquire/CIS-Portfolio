using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Date
    {
        public int _month; //private instanc variables
        public int _day;
        public int _year;

        public Date(int m = 1, int d = 1, int y = 2000)//Constructor
        {
            day = d;
            month = m;
            year = y;
        }

        public void setDate(int m, int d, int y)//variables to be accessed by form
        { day = d;
            month = m;
            year = y;
        }

        public int month//makes sure value is between 1-12
        {
            

            get
            {
                return _month;
            }
            set {
                if (value >= 1 && value <= 12)      //PRE AND POST CONDTIONS LISTEN IN FORM
                    _month = value;

                else _month = 1;
            }
        }
        public int day//makes sure value is between 1-31
        {
            get
            {
                return _day;
            }
            set { if (value >= 1 && value <= 31)
                    _day = value;
                else _day = 1; }
        }
        public int year//makes sure value is above 0
        {
            get {
                return _year;
            }
            set {
                if (value >= 0)
                    _year = value; 
                else _year = 2000;
            }
        } 
       
            
        
        public override string ToString()// value returning method
        {
            string result;// variable to hold returned value

            result = _month.ToString("d2") + "/" + _day.ToString("d2") + "/" + _year.ToString();

            return result;// returns new string
        }






    }
}
