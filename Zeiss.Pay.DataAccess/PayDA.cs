namespace Zeiss.Pay.DataAccess
{
    public class PayDA
    {
        public int GetBasicPay(string empID, Int16 Month, Int16 Year)
        {
            //connect to database
            //execute the stored procedure
            //get basic pay
            //close conection
            return 20000;
        }
    }

    public class EmployeeDA { 
        public string empID;
        public string FirstName;
        public string LastName;
        public string DOJ;

        public EmployeeDA GetEmpDetails(string empID)
        {
            EmployeeDA empDA = new EmployeeDA();
            //connedct to database and send details
            
            empDA.FirstName = "RK";
            empDA.LastName = "LN";
            empDA.DOJ = "25-05-2022";
            
            return empDA;

        }





        }
    }
