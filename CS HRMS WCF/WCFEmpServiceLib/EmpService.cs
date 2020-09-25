using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ADOEmpLib;
using EntityLayer;// For DAL Methods

namespace WCFEmpServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmpService : IEmpService
    {
        //public string GetData(int value)
        //{
        //    return "You entered: " + value;
        //}

        public void AddEmployee(Employee emp)
        {
            AdoConnected dal = new AdoConnected();
            dal.AddEmployee(emp);
        }

        public List<Employee> GetAllEmps()
        {
            AdoConnected dal = new AdoConnected();
            var emplist = dal.GetAllEmps();
            return emplist;
        }

        public void DeleteEmployee(int ecode)
        {
            AdoConnected dal = new AdoConnected();
            dal.Deleterecord(ecode);
        }

        public void UpdateEmpbyEcode(int ecode, int Salary)
        {
            AdoConnected dal = new AdoConnected();
            dal.UpdateEmpSal(ecode, Salary);
        }

        public Employee GetEmpbyEcode(int ecode)
        {
            AdoConnected dal = new AdoConnected();
            Employee record = dal.GetEmpById(ecode);
            return record;
        }
    }
}

//        public void DivideNumber()
//        {
//            try
//            {
//                int x = 100, y = 0;
//                int result = x / y;
//            }
//            catch(DivideByZeroException ex)
//            {
//                throw new MyException("Some error has occured, try later");
//            }
//        }
//    }
//}
//public class MyException : Exception
//{

//}
