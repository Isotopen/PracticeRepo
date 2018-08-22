using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Storefront
    {
        private int _id;
        private string _build;
        private string _model;
        private int _size;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id < 0)
                {
                    _id = 0;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Build
        {
            get
            {
                return _build;
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
        public int Size
        {
            get
            {
                return _size;
            }
            set {; }
        }
    }
}
