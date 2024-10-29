using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class ClsSalary
    {
        int empId;
        string eName;
        double basic, DA, HRA, gross;
        
        public void GetSalData()
        {
            Console.WriteLine("enter employee details");
            this.empId = Convert.ToInt32(Console.ReadLine());
            this.eName = Console.ReadLine();
            this.basic = Convert.ToDouble(Console.ReadLine());
        }
        public void Calculate()
        {
            this.DA = 0.4 * this.basic;
            this.HRA = 0.3 * this.basic;
            this.gross = this.basic + this.DA + this.HRA;
        }
        public void DisplaysalData()
        {
            Console.WriteLine("employee empid is" + this.empId);
            Console.WriteLine("employee name is" + this.eName);
            Console.WriteLine("employee basic is" + this.basic);
            Console.WriteLine("employee DA is" + this.DA);
            Console.WriteLine("employee HRA is" + this.HRA);
            Console.WriteLine("employee gross is" + this.gross);
        }
        public static void Main(string[] args)
        {
            ClsSalary clsSalary = new ClsSalary();
            clsSalary.GetSalData();
            clsSalary.Calculate();
            clsSalary.DisplaysalData();
        }
    }
}
