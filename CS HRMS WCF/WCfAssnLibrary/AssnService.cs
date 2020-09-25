using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AssnDAL_Lib;


namespace WCfAssnLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AssnService : IAssnService
    {
        public List<Product> GetProductsonId(string id)
        {
            //return new List<Product> { new Product { Product_ID=1,Category_ID="c1",Product_Name="shirts",Description="b1",Price=300} };
            DAL dal = new DAL();
            var records = dal.GetProductsonId(id)
                                .Select(o => new Product { Product_ID = o.Product_ID, Category_ID = o.Category_ID, Product_Name = o.Product_Name, Description = o.Description, Price = o.Price })
                                .ToList();
            return records;
        }
        public List<string> GetCategoryIds()
        {
            DAL dal = new DAL();
            var records = dal.GetCategoryIds();
            return records;
        }
    }
}
