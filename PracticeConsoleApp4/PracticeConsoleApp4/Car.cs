using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp4
{
    class Car
    {
        private int _id;
        private string _make;
        private string _model;
        private DateTime _year;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if ( _id < 0 )
                {
                    _id = 0;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set {; }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set {; }
        }
        public DateTime Year
        {
            get
            {
                return _year;
            }
            set {; }
        }
    }
}
