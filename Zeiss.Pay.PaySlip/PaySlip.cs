using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zeiss.Pay.Business;

namespace Zeiss.Pay.PaySlip
{
   


    public class PaySlip
    {
        string EmpID;
        string FirstName;
        string Department;
        DateTime DOJ;
        short Month;
        int BasicPay;
        int DA;
        int HRA;
        int LTA;
        int PF;
        int ProfTax;
        int IncomeTax;
        int Loan;

        public void PrintPaySlip(string empID, short Month, short Year)
        { 
            Console.WriteLine("Pay Slip for "+"   "+Month.ToString()+"  "+Year.ToString());
            Console.WriteLine(empID);
            EmployeeBL emp = new EmployeeBL();
            emp=emp.GetEmpDetails(empID);
            Console.WriteLine(emp.empID + " " + emp.FirstName + " " + emp.LastName);

        }


    }
    



    }

