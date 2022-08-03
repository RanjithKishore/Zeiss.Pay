using  Zeiss.Pay.DataAccess;

namespace Zeiss.Pay.Business
{
    public class PayBL
    {
        public int GetBasicPay(string empID, Int16 Month, Int16 Year)
        {
            PayDA payDA = new PayDA();
            int basicPay=payDA.GetBasicPay(empID, Month, Year);

            return basicPay;
        }

        public int CalculateDA(string empID, Int16 Month, Int16 Year)
        {
            int basicPay=GetBasicPay(empID, Month, Year);
            int da = 0;
            if (basicPay > 25000)
                da = basicPay * 12 / 100;
            else
                da = basicPay * 30 / 100;



            
            return da;
        }

    }

    public class EmployeeBL
    {
            public string empID;
            public string FirstName;
            public string LastName;
            public string DOJ;

            public EmployeeBL GetEmpDetails(string empID)
            {
                EmployeeDA empDA = new EmployeeDA();
                //connedct to database and send details
                empDA=empDA.GetEmpDetails(empID);
                EmployeeBL empBL = new EmployeeBL();
            Console.WriteLine("Pay BL" + empDA.empID);
            empBL.empID = empID;
                empBL.FirstName = empDA.FirstName;
                empBL.LastName = empDA.LastName;
                empBL.DOJ = empDA.DOJ;

                Console.WriteLine(empBL.FirstName);
                return empBL;







            }
        }
}