using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class Employee
    {
        private string _name;
        private int _age;
        private string _designation;
        private string _city;

        public Employee()
        {

        }
        public Employee(string name, int age, string designation, string city)
        {
            this._name = name;
            this._age = age;
            this._designation = designation;
            this._city = city;

        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string designation
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public override string ToString()
        {
            return string.Format("\"{0,-21}{1,-6}{2,-21}{3,-20}\",this._name,this._age,this._designation,this._city");
        }

    }
}
