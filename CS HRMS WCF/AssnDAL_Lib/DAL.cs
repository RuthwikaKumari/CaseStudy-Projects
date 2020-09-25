using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssnDAL_Lib
{
    public class DAL
    {
        public List<Product> GetProductsonId(string id)
        {
            DXCDBEntities1 dbctx = new DXCDBEntities1();
            var result = dbctx.Products
                .Where(o => o.Category_ID == id)
                .ToList();

            return result;
        }
        public List<string> GetCategoryIds()
        {
            DXCDBEntities1 dbctx = new DXCDBEntities1();
            var result = dbctx.Categories.Select(o => o.Category_ID).ToList();

            return result;
        }

    }
}
