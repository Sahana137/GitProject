using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class Properties
    {
        int empId;
        string empName;
        string empAdress;
        public int PempId
        {
            set 
            { 
                empId = value; 
            }
            get
            {
                return empId;
            }
        }
        public string PempName
        {
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }
        }
        public string PempAdress
        {
            set
            {
                empAdress = value;
            }
            get
            {
                return empAdress;
            }
        }
        public static void Main(string[] args)
        {
            Properties obj = new Properties();
            obj.PempId = Convert.ToInt32(Console.ReadLine());
            obj.PempName = Console.ReadLine();
            obj.PempAdress = Console.ReadLine();
            Console.WriteLine(obj.PempId);
            Console.WriteLine(obj.PempName);
            Console.WriteLine(obj.PempAdress);
        }
    }
}
