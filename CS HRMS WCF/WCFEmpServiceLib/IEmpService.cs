
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntityLayer; // For Entity Classes


namespace WCFEmpServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmpService
    {
        //[OperationContract]
        //void DivideNumber();
        [OperationContract]
        List<Employee> GetAllEmps();
        [OperationContract]
        void AddEmployee(Employee emp);
        [OperationContract]
        void DeleteEmployee(int ecode);
        [OperationContract]
        void UpdateEmpbyEcode(int ecode,int Salary);
        [OperationContract]
        Employee GetEmpbyEcode(int ecode);
    }
}
