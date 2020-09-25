using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAccessLayer_Lib
{
    public class ProductDAL
    {
        public void AddProduct(Product prod)
        {
            DXCDBEntities dxcdb = new DXCDBEntities();
            dxcdb.Products.Add(prod);
            dxcdb.SaveChanges();
        }
        public List<Product> GetAllProducts()
        {
            DXCDBEntities dxcdb = new DXCDBEntities();
            var records = dxcdb.Products.ToList();
            return records;
        }
        public List<string> GetAllCategoryID()
        {
            DXCDBEntities dxcdb = new DXCDBEntities();
            var records = dxcdb.Categories.Select(o => o.Category_ID).ToList();
            return records;
        }
        public Product GetProductDetails(int ID)
        {
            DXCDBEntities dxcdb = new DXCDBEntities();
            var record = dxcdb.Products.Where(o => o.ProductID == ID).SingleOrDefault();
            return record;
        }
        public string GetCategoryName(string ID)
        {
            DXCDBEntities dxcdb = new DXCDBEntities();
            var record = dxcdb.Categories.Where(o => o.Category_ID == ID).Select(o => o.Category_Name).SingleOrDefault();
            return record;
        }
    }
}
