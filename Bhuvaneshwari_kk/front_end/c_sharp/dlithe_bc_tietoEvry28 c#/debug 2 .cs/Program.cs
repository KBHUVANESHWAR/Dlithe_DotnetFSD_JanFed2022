// See https://aka.ms/new-console-template for more information
using System;

namespace PropertyDemo
{
    class Example
    {
        private int _empid, _eage;
        private string _ename, _eaddress;
        public int empid
        {
            set
            {
                _empid = value;
            }
            get
            {
                return _empid;
            }
        }
        public int eage
        {
            set
            {
                _eage = value;
            }
            get
            {
                return _eage;
            }
        }
        public string ename
        {
            set
            {
                _ename = value;
            }
            get
            {
                return _ename;
            }
        }
        public string eaddress
        {
            set
            {
                _eaddress = value;
            }                                     // get method
            get
            {
                return _eaddress;
            }
        }
        static void Main()                           // Main method
        {
            Example example = new Example();
            example._empid = 107;
            example._eage = 21;
            example._ename = "Bhuvaneshwari k";
            example._eaddress = " mysore";
            Console.WriteLine("EMP ID: " + example.empid);
            Console.WriteLine("EMP AGE: " + example.eage);
            Console.WriteLine("EMP NAME: " + example.ename);
            Console.WriteLine("EMP ADDRESS: " + example.eaddress);
        }
    }
}
