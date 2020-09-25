using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AssnDAL_Lib;

namespace WCfAssnLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAssnService
    {
        [OperationContract]
        List<Product> GetProductsonId(string id);
        [OperationContract]
        List<string> GetCategoryIds();
    }
}
